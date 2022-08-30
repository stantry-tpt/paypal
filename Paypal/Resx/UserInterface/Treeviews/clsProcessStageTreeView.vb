Imports BluePrism.AutomateProcessCore

''' Project  : Automate
''' Class    : clsProcessStageTreeView
'''
''' <summary>
''' A tree view to display process stages arranged by page and stage type.
''' </summary>
Public Class clsProcessStageTreeView
    Inherits clsAutoCheckingTreeView

    Private mProcess As BluePrismProcess
    Private mStagesInSubSheet As Dictionary(Of Guid, List(Of ProcessStage))

    Public Sub SetProcess(process As BluePrismProcess)

        mProcess = process

        mStagesInSubSheet = New Dictionary(Of Guid, List(Of ProcessStage))

        'Make lists to hold the stages in each page and collect them in a hashtable.
        For Each subsheet As ProcessSubSheet In process.SubSheets
            mStagesInSubSheet.Add(subsheet.ID, New List(Of ProcessStage))
        Next

        'Collect stage objects, keyed on subsheet ID.
        For Each stage As ProcessStage In process.GetStages()
            mStagesInSubSheet(stage.GetSubSheetID()).Add(stage)
        Next

        TreeViewNodeSorter = New NodeSorter()

    End Sub

    Public Sub Populate(processIdIsEmpty As Boolean)

        Dim sSubSheetName, sObject, sAction As String
        Dim shtNode, typeNode, stgNode As TreeNode

        Nodes.Clear()

        For Each ssId As Guid In mStagesInSubSheet.Keys

            sSubSheetName = mProcess.GetSubSheetName(ssId)
            'oSheetNode.NodeFont = New Font(Me.Font, FontStyle.Bold)
            shtNode = New TreeNode(sSubSheetName) With {.Tag = ssId}
            Nodes.Add(shtNode)

            If processIdIsEmpty Then
                For Each e In [Enum].GetValues(GetType(StageTypes))
                    shtNode.Nodes.Add(New TreeNode(StageTypeName.GetLocalizedFriendlyName(e.ToString(), True)) With {.Tag = e})
                Next
            Else
                Dim list = [Enum].GetValues(GetType(StageTypes)) _
                                .Cast(Of StageTypes)() _
                                .Where(Function(o) _
                                    o <> StageTypes.Code AndAlso
                                    o <> StageTypes.Read AndAlso
                                    o <> StageTypes.Write AndAlso
                                    o <> StageTypes.Navigate AndAlso
                                    o <> StageTypes.WaitStart)

                For Each e In list
                    shtNode.Nodes.Add(New TreeNode(StageTypeName.GetLocalizedFriendlyName(e.ToString(), True)) With {.Tag = e})
                Next
            End If

            For Each stg As ProcessStage In mStagesInSubSheet(ssId)

                For Each typeNode In shtNode.Nodes
                    If stg.StageType.Equals(typeNode.Tag) Then
                        stgNode = New TreeNode(stg.GetName) With {.Tag = stg}
                        typeNode.Nodes.Add(stgNode)

                        Select Case stg.StageType

                            Case StageTypes.Calculation, StageTypes.Decision
                                stgNode.ToolTipText =
                                 CType(stg, IExpressionHolder).Expression.LocalForm

                            Case StageTypes.Action
                                sObject = ""
                                sAction = ""
                                CType(stg, Stages.ActionStage).GetResource(sObject, sAction)
                                If sObject <> "" And sAction <> "" Then
                                    stgNode.ToolTipText = sObject & "." & sAction
                                End If

                            Case StageTypes.Skill
                                Dim skill = CType(stg, Stages.SkillStage)
                                stgNode.ToolTipText = skill.ActionName

                            Case StageTypes.Data
                                stgNode.ToolTipText = CType(stg, Stages.DataStage).GetShortText

                            Case Else
                                If stg.GetNarrative <> "" Then
                                    stgNode.ToolTipText = stg.GetNarrative
                                End If
                        End Select

                        Exit For
                    End If
                Next

            Next

        Next

    End Sub

    Public Sub EnsureVisible(gSubSheetID As Guid)

        For Each oSheetNode As TreeNode In Nodes
            If gSubSheetID.Equals(oSheetNode.Tag) Then
                oSheetNode.EnsureVisible()
                Exit For
            End If
        Next

    End Sub

    Public Sub CheckSubSheet(gSubSheetID As Guid)

        For Each oSheetNode As TreeNode In Nodes
            If gSubSheetID.Equals(oSheetNode.Tag) Then
                oSheetNode.Checked = True
                Exit For
            End If
        Next

    End Sub

    Public Sub Expand(gSubSheetID As Guid, Optional bExpandChildren As Boolean = True)

        For Each oSheetNode As TreeNode In Nodes
            If gSubSheetID.Equals(oSheetNode.Tag) Then
                oSheetNode.Expand()
                If bExpandChildren Then
                    For Each oTypeNode As TreeNode In oSheetNode.Nodes
                        oTypeNode.Expand()
                    Next
                End If
                Exit For
            End If
        Next

    End Sub

    Public Function SomeStagesAreChecked() As Boolean

        For Each oSheetNode As TreeNode In Nodes
            For Each oTypeNode As TreeNode In oSheetNode.Nodes
                Return oTypeNode.Nodes.Cast(Of TreeNode)().Any(Function(oStageNode) oStageNode.Checked)
            Next
        Next

        Return False

    End Function

    Public Function AllStagesAreChecked() As Boolean

        Dim iUnChecked As Integer

        For Each oSheetNode As TreeNode In Nodes
            For Each oTypeNode As TreeNode In oSheetNode.Nodes
                For Each oStageNode As TreeNode In oTypeNode.Nodes
                    If Not oStageNode.Checked Then
                        iUnChecked += 1
                    End If
                Next
            Next
        Next
        Return iUnChecked = 0

    End Function

    Public Function SubSheetIsChecked(gSubSheetID As Guid) As Boolean

        For Each oSheetNode As TreeNode In Nodes
            If gSubSheetID.Equals(oSheetNode.Tag) Then
                Return oSheetNode.Checked
            End If
        Next
        Return False

    End Function

    Public Function GetStageTypesOfCheckedStages() As StageTypes

        Dim iStageType As StageTypes

        For Each oSheetNode As TreeNode In Nodes
            For Each oTypeNode As TreeNode In oSheetNode.Nodes
                If (iStageType And CType(oTypeNode.Tag, StageTypes)) > 0 Then
                    'Got this stage type already
                Else
                    For Each oStageNode As TreeNode In oTypeNode.Nodes
                        If oStageNode.Checked Then
                            iStageType = iStageType Or CType(oTypeNode.Tag, StageTypes)
                            Exit For
                        End If
                    Next
                End If
            Next
        Next
        Return iStageType

    End Function

    Public Function GetCheckedStageIDs() As Guid()

        Dim aCheckedStages As New List(Of Guid)

        For Each oSheetNode As TreeNode In Nodes
            For Each oTypeNode As TreeNode In oSheetNode.Nodes
                For Each oStageNode As TreeNode In oTypeNode.Nodes
                    If oStageNode.Checked Then
                        aCheckedStages.Add(CType(oStageNode.Tag, ProcessStage).GetStageID)
                    End If
                Next
            Next
        Next
        Return aCheckedStages.ToArray()

    End Function

    Private Class NodeSorter
        Implements IComparer

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare

            Return String.Compare(CType(x, TreeNode).Text, CType(y, TreeNode).Text)

        End Function

    End Class

End Class
