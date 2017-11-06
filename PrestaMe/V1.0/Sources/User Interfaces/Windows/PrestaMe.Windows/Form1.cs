#region Uso e Invocacion de Librerias de Clases a ser utilizadas
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


using PrestaMe.Layers.Application;

#endregion Uso de Invocacion de Librerias de Clase a ser Utilizadas 


#region Logica de la Clase, Segun NameSpace Especificado 

namespace PrestaMe.Windows.Forms

{
    #region Estructura de Metodos, Propiedades, Procedimientos y Funciones de la clase Indicada
    /// <summary>
    /// Estructura de Metodos, Propiedades, Procedimientos y Funciones de la clase Indicada
    /// </summary>
    public partial class formSplash : Form
    {
        private object alignment;
        #region Constructor Principal sin Parametros Invocados
        /// <summary>
        /// Constructor sin Parametrosio

        /// </summary>

        public formSplash()
        {
            // Procesos Iniciales del Formulario. Inic
            InitializeComponent();

            // Invocacion y Carga de los Elementos del nodo a los Objetos del Formulario Splash
            //CargarSplashFromArchivoXMLAplication();
            // Procesos Iniciales del Formulario. Fin

        }
        #endregion Constructor Principal Sin Parametros Invocados

        #region Aplicar el Ambiente del splash la Configuracion del Archivo de la Aplicacion

        ///<summary>
        /// Procedimientos Para Aplicar el Ambiente del Splash Segun la Configuracion del Archivo de la Aplicacion
        ///</summary>
        private void CargarSplashFromArchivoXMLAplication()
        {
            //Declaracion de Variable Locales. Inicio

            string stringPathImageFiles = ClassAplication.stringPathImageFiles,

                StringImageFile = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Formulario", "BackGround-Image"),
                StringTransparentColor = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Formulario", "Transparency-key"),
                StringBackColor = ClassAplication.buscarNodoArchivoXML
                ("AppConfig.XML", "Formulario", "Back-Color");

            // Declaracion de Variables Locales. Fin 

            this.Visible = false;

            // Aplicar Cambio de Tamaño de Formulario. Inicio
            this.Width = int.Parse(ClassAplication.buscarNodoArchivoXML
                ("AppConfig.XML", "Formulario", "Width"));
            this.Height = int.Parse(ClassAplication.buscarNodoArchivoXML
                ("AppConfig,XML", "Formulario", "Height"));

            // Aplicar Cambio de tamaño de Formulario. Fin

            // Aplicar Transparencia o No, y BackColor al Formulario.Incio

            StringBackColor = String.IsNullOrEmpty(StringBackColor) ? "Control" : StringBackColor;
            StringTransparentColor = String.IsNullOrEmpty(StringTransparentColor) ? "Control" : StringTransparentColor;
            this.BackColor = Color.FromName(StringBackColor);
            this.TransparencyKey = Color.FromName(StringTransparentColor);
            // Aplicar Transparencia o no, y Backcolor al Formulario. Fin

            // Verificar Si el Archivo BackGroundImage Existe en la Ruta Especificada. Inicio
            stringPathImageFiles = stringPathImageFiles.Substring(stringPathImageFiles.Length - 1, 1) == @"\" ? stringPathImageFiles : stringPathImageFiles + @"\";

            try
            {
                this.BackgroundImage = Image.FromFile(System.IO.File.Exists(stringPathImageFiles + stringPathImageFiles) ? stringPathImageFiles + stringPathImageFiles : ClassAplication.stringPathImageFiles + stringPathImageFiles + stringPathImageFiles);
            }
            catch (Exception exception)
            {
                this.BackgroundImage = null;
                this.BackColor = Color.White;
            }

            // Verificar Si el Archivo backGroundImage Existe en la Ruta Especificada.  Fin.

            // Ubicación Versión Aplicación.  Inicio.  

            labelVersion.Text = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Identificación", "versión");

            labelVersion.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "location-x")), int.Parse
             (ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "location-y")));

            labelVersion.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "back-color"));

            labelVersion.ForeColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "fore-color"));

            labelVersion.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-name"), int.Parse

                (ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-size")));

            labelVersion.Font = new Font(labelVersion.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-bold").ToLower() == "true" ? FontStyle.Bold : labelVersion.Font.Style);

            labelVersion.Font = new Font(labelVersion.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-italic").ToLower() == "true" ? FontStyle.Italic : labelVersion.Font.Style);

            labelVersion.Font = new Font(labelVersion.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-regular").ToLower() == "true" ? FontStyle.Regular : labelVersion.Font.Style);

            labelVersion.Font = new Font(labelVersion.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : labelVersion.Font.Style);

            labelVersion.Font = new Font(labelVersion.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "font-underline").ToLower() == "true" ? FontStyle.Underline : labelVersion.Font.Style);

            labelVersion.AutoSize = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "auto-size").ToLower() == "true" ? true : false;

            labelVersion.TextAlign = contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "alignment").ToLower());

            labelVersion.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "visible").ToLower() == "true" ? true : false;

            labelVersion.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "dock"));

            labelVersion.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Versión", "anchor"));

            // Ubicación Versión Aplicación.  Fin

            // Ubicación Progress Message de la Aplicación.  Inicio.

            labelProgressMsg.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "location-x")), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "location-y")));


            labelProgressMsg.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "back-color"));
            labelProgressMsg.ForeColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "fore-color"));

            labelProgressMsg.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "font-name"), float.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "font-size")));

            labelProgressMsg.Font = new Font(labelProgressMsg.Font,
                ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "font-bold").ToLower() == "true" ? FontStyle.Bold : labelProgressMsg.Font.Style);
            labelProgressMsg.Font = new Font(labelProgressMsg.Font,
                    ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "font-italic").ToLower() == "true" ?
                    FontStyle.Italic :
                    labelProgressMsg.Font.Style); labelProgressMsg.Font = new Font(labelProgressMsg.Font,
                         ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "font-regular").ToLower() == "true" ?
                     FontStyle.Regular : labelProgressMsg.Font.Style);
            labelProgressMsg.Font = new Font(labelProgressMsg.Font,
            ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : labelProgressMsg.Font.Style);

            labelProgressMsg.Font = new Font(labelProgressMsg.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "Font-underline").ToLower() == "True" ?FontStyle.Underline : labelProgressMsg.Font.Style);
            labelProgressMsg.AutoSize = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "Auto-Size").ToLower() == "True" ? true : false;
            labelProgressMsg.TextAlign = contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "alignment").ToLower());

            labelProgressMsg.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "visible").ToLower() == "true" ? true : false;
            labelProgressMsg.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "dock"));
            labelProgressMsg.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressMsg", "anchor"));
            radProgressBar1.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "location-x")), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "location-y")));

            radProgressBar1.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "back-color"));
            radProgressBar1.ForeColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "fore-color"));

            radProgressBar1.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-name"), float.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-size"))); radProgressBar1.Font = new Font(radProgressBar1.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-bold").ToLower() == "true" ? FontStyle.Bold : radProgressBar1.Font.Style); radProgressBar1.Font = new Font(radProgressBar1.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-italic").ToLower() == "true" ? FontStyle.Italic : radProgressBar1.Font.Style); radProgressBar1.Font = new Font(radProgressBar1.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-regular").ToLower() == "true" ?

FontStyle.Regular : radProgressBar1.Font.Style); radProgressBar1.Font = new Font(radProgressBar1.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : radProgressBar1.Font.Style); radProgressBar1.Font = new Font(radProgressBar1.Font,
    ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "font-underline").ToLower() == "true" ? FontStyle.Underline : radProgressBar1.Font.Style);

            radProgressBar1.AutoScroll = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "auto-size").ToLower() == "true" ? true : false;
            radProgressBar1.TextAlignment = ContentAlignment.MiddleCenter; contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "alignment").ToLower());

            radProgressBar1.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "visible").ToLower() == "true" ? true : false;
            radProgressBar1.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "dock"));
            radProgressBar1.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "ProgressBar", "anchor"));

            // Ubicación ProgressBar de la Aplicación.  Fin. 

            // CopyRight de la Aplicación.  Inicio.   

            labelCopyRight.Text = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Identificación", "copy-right");

            labelCopyRight.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "location-x")), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "location-y")));

            labelCopyRight.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "back-color")); labelCopyRight.ForeColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "fore-color"));

            labelCopyRight.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-name"), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-size")));

            labelCopyRight.Font = new Font(labelCopyRight.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-bold").ToLower() == "true" ? FontStyle.Bold : labelCopyRight.Font.Style);

            labelCopyRight.Font = new Font(labelCopyRight.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-italic").ToLower() == "true" ?
                FontStyle.Italic : labelCopyRight.Font.Style); labelCopyRight.Font = new Font(labelCopyRight.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-regular").ToLower() == "true" ?
                    FontStyle.Regular : labelCopyRight.Font.Style);

            labelCopyRight.Font = new Font(labelCopyRight.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : labelCopyRight.Font.Style);
            labelCopyRight.Font = new Font(labelCopyRight.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "font-underline").ToLower() == "true" ? FontStyle.Underline : labelCopyRight.Font.Style);

            labelCopyRight.AutoSize = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "auto-size").ToLower() == "true" ? true : false;
            labelCopyRight.TextAlign = contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "alignment").ToLower());

            labelCopyRight.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "visible").ToLower() == "true" ? true : false;

            labelCopyRight.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "dock"));
            labelCopyRight.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "CopyRight", "anchor"));

            // CopyRight de la Aplicación.  Fin.


            // Siglas de la Aplicacion. Inicio

            labelSiglas.Text = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Identificación", "siglas");
            labelSiglas.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "location-x")), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "location-y")));

            labelSiglas.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "back-color"));
            labelSiglas.ForeColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "fore-color"));

            labelSiglas.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-name"), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-size")));

            labelSiglas.Font = new Font(labelSiglas.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-bold").ToLower() == "true" ? FontStyle.Bold : labelSiglas.Font.Style); labelSiglas.Font = new Font(labelSiglas.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-italic").ToLower() == "true" ? FontStyle.Italic : labelSiglas.Font.Style); labelSiglas.Font = new Font(labelSiglas.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-regular").ToLower() == "true" ? FontStyle.Regular : labelSiglas.Font.Style);
            labelSiglas.Font = new Font(labelSiglas.Font,
                ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : labelSiglas.Font.Style);
            labelSiglas.Font = new Font(labelSiglas.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "font-underline").ToLower() == "true" ? FontStyle.Underline : labelSiglas.Font.Style);

            labelSiglas.AutoSize = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "auto-size").ToLower() == "true" ? true : false;
            labelSiglas.TextAlign = contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "alignment").ToLower());

            labelSiglas.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "visible").ToLower() == "true" ? true : false;

            labelSiglas.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "dock"));

            labelSiglas.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Siglas", "anchor"));

            // Siglas de la Aplicacion. Fin 

            //Producto de la Aplicacion. Inicio 

            labelProducto.Text = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Identificación", "producto"); labelProducto.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "location-x")), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "location-y")));

            labelProducto.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "fore-color"));

            labelProducto.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-name"), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-size"))); labelProducto.Font = new Font(labelProducto.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-bold").ToLower() == "true" ? FontStyle.Bold : labelProducto.Font.Style); labelProducto.Font = new Font(labelProducto.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-italic").ToLower() == "true" ? FontStyle.Italic : labelProducto.Font.Style); labelProducto.Font = new Font(labelProducto.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-regular").ToLower() == "true" ? FontStyle.Regular : labelProducto.Font.Style); labelProducto.Font = new Font(labelProducto.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : labelProducto.Font.Style); labelProducto.Font = new Font(labelProducto.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "font-underline").ToLower() == "true" ? FontStyle.Underline : labelProducto.Font.Style);

            labelProducto.AutoSize = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "auto-size").ToLower() == "true" ? true : false; labelProducto.TextAlign = contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "alignment").ToLower());

            labelProducto.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "visible").ToLower() == "true" ? true : false;

            labelProducto.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "dock"));

            labelProducto.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Producto", "anchor"));
            // Producto de la Aplicacion. Fin

            // Alias de la Aplicacion. Inicio 

            labelAlias.Text = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Identificacion", "alias");
            labelAlias.Location = new Point(int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "Location-x")), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "Location-y")));

            labelAlias.BackColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "back-color")); labelAlias.ForeColor = Color.FromName(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "fore-color"));

            labelAlias.Font = new Font(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-name"), int.Parse(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-size"))); labelAlias.Font = new Font(labelAlias.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-bold").ToLower() == "true" ? FontStyle.Bold : labelAlias.Font.Style); labelAlias.Font = new Font(labelAlias.Font, ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-italic").ToLower() == "true" ? FontStyle.Italic : labelAlias.Font.Style);
            labelAlias.Font = new Font(labelAlias.Font,
                ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-regular").ToLower() == "true" ? FontStyle.Regular : labelAlias.Font.Style);
            labelAlias.Font = new Font(labelAlias.Font,
                ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-strikeout").ToLower() == "true" ? FontStyle.Strikeout : labelAlias.Font.Style);
            labelAlias.Font = new Font(labelAlias.Font,
                ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "font-underline").ToLower() == "true" ? FontStyle.Underline : labelAlias.Font.Style);

            labelAlias.AutoSize = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "auto-size").ToLower() == "true" ? true : false; labelAlias.TextAlign = contentAlignment(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "alignment").ToLower());
            labelAlias.Visible = ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "visible").ToLower() == "true" ? true : false;

            labelAlias.Dock = ClassAplication.dockStyle(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "dock"));

            labelAlias.Anchor = ClassAplication.anchorStyles(ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Alias", "anchor"));
            // Alias de la Aplicacion. Fin.
            this.Visible = true;
        }

        #endregion Aplicar el Ambiente del Splash Según la Configuración del Archivo de la Aplicación

        #region Alineacion de un Texto Cualquiera
        /// <summary>
        /// Procedimiento de Alineacion de un Texto Cualquiera
        /// </summary>
        ///<param name= "StringParameterTipoAlineacion"></param>
        ///<returns></returns>

        private ContentAlignment contentAlignment(string stringParameterTipoAlineacion)
        {
            ContentAlignment ContentAligment = new ContentAlignment();
            switch (stringParameterTipoAlineacion.ToLower())
            {
                case "middlecenter":
                    {

                        ContentAligment = ContentAlignment.MiddleCenter;
                        break;
                    }
                case "MiddleLeft":
                    {
                        ContentAligment = ContentAlignment.MiddleLeft;
                        break;
                    }
                case "MiddleRight":
                    {
                        ContentAligment = ContentAlignment.MiddleRight;
                        break;
                    }
                case "BottomCenter":
                    {
                        ContentAligment = ContentAlignment.BottomCenter;
                        break;
                    }
                case "BottomLeft":
                    {
                        ContentAligment = ContentAlignment.BottomLeft;
                        break;
                    }
                case "BottomRight":
                    {
                        ContentAligment = ContentAlignment.BottomRight;
                        break;
                    }
                case "TopCenter":
                    {
                        ContentAligment = ContentAlignment.TopCenter;
                        break;
                    }
                case "TopLeft":
                    {
                        ContentAligment = ContentAlignment.TopLeft;
                        break;
                    }
                case "TopRight":
                    {
                        ContentAligment = ContentAlignment.TopRight;
                        break;
                    }
            }
            return ContentAligment;
        }
        #endregion Alineacion de un Texto Cualquiera

        #region Tick de Control Avance del ProgressBar
        ///<summary>
        ///Procedimiento para Representar el Avance del ProgressBar
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"></param>
        private void TimerProgressBar_Tick(object sender, EventArgs e)
        {
            if (radProgressBar1.Value1 < radProgressBar1.Maximum)
            {
                radProgressBar1.Value1 = radProgressBar1.Value1 + 1;
            }
            else
            {
                //this.Dispose();
                //this.Close();
            }
        }

        #endregion Tick de Control Avance del ProgressBar

        #region Metodo Load del Formulario
        ///<summary>
        /// Invocar el Metodo Load del Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FormSplash_Load(object sender, EventArgs e)
        {
            timerProgressBar.Start();
            Thread threadSplashCharge = new Thread(LoadTreadProcess);
            threadSplashCharge.Start();
        }
        #endregion Metodo Load del Formulario

        #region Invocacion Procesos Segundo Plano ProgressBar
        ///<summary>
        /// Procedimiento para Invocacion Procesos Segundo Plano ProgressBar
        /// </summary>

        private void LoadTreadProcess()
        {
            timerProgressBar.Start(); this.Invoke((MethodInvoker)(() => setMessage("Verificando Archivos XML Configuración...")));
            ClassAplication.verificarArchivosXMLAplicacion(); Thread.Sleep(1000);

            this.Invoke((MethodInvoker)(() => setMessage("Verificando Datos Iniciales Aplicación...")));
            ClassAplication.verificarDataInicial();

            this.Invoke((MethodInvoker)(() => setMessage("Aplicando Interfaz de Usuario Seleccionado...")));
            Telerik.WinControls.ThemeResolutionService.ApplicationThemeName = Layers.Application.ClassAplication.buscarNodoArchivoXML("AppConfig.XML", "Entorno", "interfaz");

            this.Invoke((MethodInvoker)(() => setMessage("Invocando Control de Acceso Aplicación...")));
            radProgressBar1.Value1 = 100; timerProgressBar.Stop(); Thread.Sleep(1000);

            this.Invoke((MethodInvoker)delegate {
                this.Close();
            });
        }
        #endregion Invocacion Procesos Segundo Plano ProgressBar

        #region Despliegue de Mensajes Procesos Segundo Plano
        ///<summary>
        /// Procedimientos para Despliegue de Mensajes Procesos Segundo Plano
        /// </summary>
        /// <param name="stringParameterMessage"></param>

        private void setMessage(string stringParameterMessage)
        {
            labelProgressMsg.Text = stringParameterMessage;
        }
        #endregion Despliegue de Mensajes Procesos Segunfo Plano 

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    #endregion Estructura de Metodos, Propiedades, Procedimientos y Funciones de la Clase Indicada
}
  #endregion logica de la Clase, Segun NameSpace Especificado

