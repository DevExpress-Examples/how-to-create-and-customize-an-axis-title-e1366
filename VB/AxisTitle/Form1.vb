﻿Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace AxisTitle
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create an empty chart.
            Dim chartControl1 As New ChartControl()

            ' Create a bar series and add points to it.
            Dim series1 As New Series("Series 1", ViewType.Bar)
            series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
            series1.Points.Add(New SeriesPoint("B", New Double() { 12 }))
            series1.Points.Add(New SeriesPoint("C", New Double() { 17 }))
            series1.Points.Add(New SeriesPoint("D", New Double() { 14 }))
            series1.Points.Add(New SeriesPoint("E", New Double() { 17 }))

            ' Add the series to the chart.
            chartControl1.Series.Add(series1)

            ' Hide the legend (if necessary).
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Cast the chart's diagram to the XYDiagram type, to access its axes.
            Dim diagram As XYDiagram = TryCast(chartControl1.Diagram, XYDiagram)

            ' Customize the appearance of the X-axis title.
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            diagram.AxisX.Title.Alignment = StringAlignment.Center
            diagram.AxisX.Title.Text = "X-axis Title"
            diagram.AxisX.Title.TextColor = Color.Red
            diagram.AxisX.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
            diagram.AxisX.Title.Font = New Font(Me.Font.FontFamily.Name, 14, FontStyle.Bold)

            ' Customize the appearance of the Y-axis title.
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            diagram.AxisY.Title.Alignment = StringAlignment.Center
            diagram.AxisY.Title.Text = "Y-axis Title"
            diagram.AxisY.Title.TextColor = Color.Blue
            diagram.AxisY.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
            diagram.AxisY.Title.Font = New Font(Me.Font.FontFamily.Name, 14, FontStyle.Bold)

            ' Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill
            Me.Controls.Add(chartControl1)
        End Sub

    End Class
End Namespace