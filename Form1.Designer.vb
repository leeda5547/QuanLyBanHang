<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýKHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BánHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýBHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýSPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuanLyKhachHang = New System.Windows.Forms.Button()
        Me.btnQuanLyBanHang = New System.Windows.Forms.Button()
        Me.btnQuanLySanPham = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem, Me.BánHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýKHToolStripMenuItem})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'QuảnLýKHToolStripMenuItem
        '
        Me.QuảnLýKHToolStripMenuItem.Name = "QuảnLýKHToolStripMenuItem"
        Me.QuảnLýKHToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.QuảnLýKHToolStripMenuItem.Text = "Quản lý KH"
        '
        'BánHàngToolStripMenuItem
        '
        Me.BánHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýBHToolStripMenuItem})
        Me.BánHàngToolStripMenuItem.Name = "BánHàngToolStripMenuItem"
        Me.BánHàngToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.BánHàngToolStripMenuItem.Text = "Bán hàng"
        '
        'QuảnLýBHToolStripMenuItem
        '
        Me.QuảnLýBHToolStripMenuItem.Name = "QuảnLýBHToolStripMenuItem"
        Me.QuảnLýBHToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.QuảnLýBHToolStripMenuItem.Text = "Quản lý BH"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuảnLýSPToolStripMenuItem})
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
        '
        'QuảnLýSPToolStripMenuItem
        '
        Me.QuảnLýSPToolStripMenuItem.Name = "QuảnLýSPToolStripMenuItem"
        Me.QuảnLýSPToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.QuảnLýSPToolStripMenuItem.Text = "Quản lý SP"
        '
        'btnQuanLyKhachHang
        '
        Me.btnQuanLyKhachHang.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuanLyKhachHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnQuanLyKhachHang.Location = New System.Drawing.Point(90, 115)
        Me.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang"
        Me.btnQuanLyKhachHang.Size = New System.Drawing.Size(108, 92)
        Me.btnQuanLyKhachHang.TabIndex = 1
        Me.btnQuanLyKhachHang.Text = "Quản lý khách hàng"
        Me.btnQuanLyKhachHang.UseVisualStyleBackColor = False
        '
        'btnQuanLyBanHang
        '
        Me.btnQuanLyBanHang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnQuanLyBanHang.Location = New System.Drawing.Point(260, 115)
        Me.btnQuanLyBanHang.Name = "btnQuanLyBanHang"
        Me.btnQuanLyBanHang.Size = New System.Drawing.Size(108, 92)
        Me.btnQuanLyBanHang.TabIndex = 2
        Me.btnQuanLyBanHang.Text = "Quản lý " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bán hàng"
        Me.btnQuanLyBanHang.UseVisualStyleBackColor = True
        '
        'btnQuanLySanPham
        '
        Me.btnQuanLySanPham.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btnQuanLySanPham.Location = New System.Drawing.Point(429, 115)
        Me.btnQuanLySanPham.Name = "btnQuanLySanPham"
        Me.btnQuanLySanPham.Size = New System.Drawing.Size(108, 92)
        Me.btnQuanLySanPham.TabIndex = 3
        Me.btnQuanLySanPham.Text = "Quản lý" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " sản phẩm"
        Me.btnQuanLySanPham.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(636, 345)
        Me.Controls.Add(Me.btnQuanLySanPham)
        Me.Controls.Add(Me.btnQuanLyBanHang)
        Me.Controls.Add(Me.btnQuanLyKhachHang)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Rambo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BánHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnQuanLyKhachHang As System.Windows.Forms.Button
    Friend WithEvents btnQuanLyBanHang As System.Windows.Forms.Button
    Friend WithEvents btnQuanLySanPham As System.Windows.Forms.Button
    Friend WithEvents QuảnLýKHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýBHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuảnLýSPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
