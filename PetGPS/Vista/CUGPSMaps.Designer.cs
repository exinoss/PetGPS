namespace PetGPS.Vista
{
    partial class CUGPSMaps
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUGPSMaps));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLongitud = new System.Windows.Forms.Label();
            this.lbLatitud = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbAlerta = new System.Windows.Forms.Label();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnZoomP = new System.Windows.Forms.Button();
            this.btnZoomN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRango = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(4, 44);
            this.gmap.Margin = new System.Windows.Forms.Padding(4);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(555, 484);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "MAPA";
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(611, 44);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(155, 52);
            this.btnHome.TabIndex = 59;
            this.btnHome.Text = "FIJAR ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 61;
            this.label3.Text = "LONGITUD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 62;
            this.label2.Text = "LATITUD";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLongitud);
            this.groupBox1.Controls.Add(this.lbLatitud);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(611, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(472, 202);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COORDENADAS";
            // 
            // lbLongitud
            // 
            this.lbLongitud.AutoSize = true;
            this.lbLongitud.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLongitud.Location = new System.Drawing.Point(23, 158);
            this.lbLongitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLongitud.Name = "lbLongitud";
            this.lbLongitud.Size = new System.Drawing.Size(164, 23);
            this.lbLongitud.TabIndex = 66;
            this.lbLongitud.Text = "valor longitud";
            // 
            // lbLatitud
            // 
            this.lbLatitud.AutoSize = true;
            this.lbLatitud.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLatitud.Location = new System.Drawing.Point(23, 74);
            this.lbLatitud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLatitud.Name = "lbLatitud";
            this.lbLatitud.Size = new System.Drawing.Size(153, 23);
            this.lbLatitud.TabIndex = 65;
            this.lbLatitud.Text = "valor latitud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(352, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "______________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 24);
            this.label4.TabIndex = 63;
            this.label4.Text = "______________________________________";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciar.Image")));
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.Location = new System.Drawing.Point(939, 44);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(144, 52);
            this.btnIniciar.TabIndex = 64;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRango);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbAlerta);
            this.groupBox2.Controls.Add(this.lbDistancia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(611, 313);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(472, 202);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALERTA DISTANCIA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbAlerta
            // 
            this.lbAlerta.AutoSize = true;
            this.lbAlerta.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlerta.Location = new System.Drawing.Point(20, 136);
            this.lbAlerta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAlerta.Name = "lbAlerta";
            this.lbAlerta.Size = new System.Drawing.Size(264, 40);
            this.lbAlerta.TabIndex = 66;
            this.lbAlerta.Text = "ESTA EN RANGO";
            this.lbAlerta.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistancia.Location = new System.Drawing.Point(23, 74);
            this.lbDistancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(175, 23);
            this.lbDistancia.TabIndex = 65;
            this.lbDistancia.Text = "valor distancia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 24);
            this.label9.TabIndex = 63;
            this.label9.Text = "___________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 62;
            this.label10.Text = "DISTANCIA";
            // 
            // btnDetener
            // 
            this.btnDetener.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Image = ((System.Drawing.Image)(resources.GetObject("btnDetener.Image")));
            this.btnDetener.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetener.Location = new System.Drawing.Point(773, 44);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(157, 52);
            this.btnDetener.TabIndex = 68;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnZoomP
            // 
            this.btnZoomP.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomP.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomP.Image")));
            this.btnZoomP.Location = new System.Drawing.Point(515, 2);
            this.btnZoomP.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomP.Name = "btnZoomP";
            this.btnZoomP.Size = new System.Drawing.Size(44, 41);
            this.btnZoomP.TabIndex = 69;
            this.btnZoomP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomP.UseVisualStyleBackColor = true;
            this.btnZoomP.Click += new System.EventHandler(this.btnZoomP_Click);
            // 
            // btnZoomN
            // 
            this.btnZoomN.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomN.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomN.Image")));
            this.btnZoomN.Location = new System.Drawing.Point(560, 44);
            this.btnZoomN.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomN.Name = "btnZoomN";
            this.btnZoomN.Size = new System.Drawing.Size(44, 41);
            this.btnZoomN.TabIndex = 70;
            this.btnZoomN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoomN.UseVisualStyleBackColor = true;
            this.btnZoomN.Click += new System.EventHandler(this.btnZoomN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 24);
            this.label8.TabIndex = 67;
            this.label8.Text = "RANGO ALERTA";
            // 
            // txtRango
            // 
            this.txtRango.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtRango.Location = new System.Drawing.Point(282, 74);
            this.txtRango.Name = "txtRango";
            this.txtRango.Size = new System.Drawing.Size(167, 31);
            this.txtRango.TabIndex = 69;
            // 
            // CUGPSMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnZoomN);
            this.Controls.Add(this.btnZoomP);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmap);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CUGPSMaps";
            this.Size = new System.Drawing.Size(1097, 545);
            this.Load += new System.EventHandler(this.CUGPSMaps_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbLongitud;
        private System.Windows.Forms.Label lbLatitud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbAlerta;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnZoomP;
        private System.Windows.Forms.Button btnZoomN;
        private System.Windows.Forms.TextBox txtRango;
        private System.Windows.Forms.Label label8;
    }
}
