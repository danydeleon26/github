#region     CopyRight

#endregion  CopyRight

#region     Uso e Invocación de Librerías de Clase a Ser Utilizadas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;


#endregion     Uso e Invocación de Librerías de Clase a Ser Utilizadas

#region     Logica de la Clase, Según NameSpace Especificado

namespace PrestaMe.Layers.Application
{
    #region     Clase Global, Contenedora de los Procedimientos, Funciones, Eventos y Propiedades de la Aplicacion


    /// <summary> 
    /// Clase Contenedora de los Procedimientos, Funciones, Eventos y
    /// Propiedades de la Aplicacion.
    /// </summary> 

    public class ClassAplication
    {
        #region   Variables, Constantes, Propiedades y Declaraciones Adicionales con Sus Respectivos Ambitos y Alcances

        public static int? IdCia = -1;
        public static int? IdSucursal = -1;
        public static int? IdUsuario = -1;

        public static string idRegistro = string.Empty;
        public static string operacion = string.Empty;

        public static string compania = string.Empty;
        public static string sucursal = string.Empty;

        public static string userName = string.Empty;
        public static string loginName = string.Empty;
        public static string rolUserName = string.Empty;


        public static string stringPathXMLFiles;// = buscarNodoArchivoXML("Appconfig.xml", "Carpetas", "xml");
        public static string StringPathXMLFiles;// = buscarNodoArchivoXML("Appconfig.xml", "Carpetas", "reportes");
        public static string stringPathImageFiles;// = buscarNodoArchivoXML("Appconfig.xml", "Carpetas", "imágenes");
        public static string stringPathDocFiles;// = buscarNodoArchivoXML("Appconfig.xml", "Carpetas", "documentos");

        public static string stringDirectorioBase = directorioBaseAplicacion();

        public enum hashType : int

        {
            MD5,
            SHA1,
            SHA128,
            SHA256,
            SHA384,
            SHA512,
            SHA634
        }

        #endregion Variables, Constantes, Propiedades y Declaraciones Adicionales con Sus Respectivos Ambitos y Alcances

        #region     Determinar y Retornar el Directorio Base de la Aplicacion

        /// <summary>  
        /// Determinar y Retornar el Directorio Base de la Aplicacion 
        /// </summary> 
        /// <returns></returns>



        public static string directorioBaseAplicacion()
        {
            if (System.AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin") > 0)
            {
                stringDirectorioBase =
                    System.AppDomain.CurrentDomain.BaseDirectory.Substring(0
                    , System.AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin"));
            }

            else

            { stringDirectorioBase =
              System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            }

            return stringDirectorioBase;

        }

        #endregion  Determinar y Retornar el Directorio Base de la Aplicacion

        #region     Verificacion de los Registros Básicos por Defecto de las Principales Tablas de la Aplicacion

        /// Proceso de Verificacion de los Registros Básicos por Defecto de las Principales Tablas de la Aplicacion  
        /// </summary>

        public static void verificarDataInicial()

        {
            // Colocar codigo aqui ...
        }

        #endregion  Verificacion de los Registros Básicos por Defecto de las Principales Tablas de la Aplicacion

        #region     Configuracion de los Registros Básicos por Defecto de las Principales Tablas de la Aplicacion


        /// <summary> 
        /// Proceso de Verificacion de los Registros Básicos por Defecto de las Principales Tablas de la Aplicacion  
        /// </summary> 

        public static void configurarDataInicial()
        {
            // Colocar codigo aqui ...
        }
        #endregion  Configuracion de los Registros Básicos por Defecto de las Principales Tablas de la Aplicacion

        #region     Verificación de los Archivos XML AppConfig y AppError Respectivamente
        /// <summary>       
        /// Verificación de los Archivos XML AppConfig y AppError Respectivamente 
        /// </summary> 

        public static void verificarArchivosXMLAplicacion()
        {
            if (System.IO.File.Exists(directorioBaseAplicacion()
                + stringPathXMLFiles + @"\AppConfig.xml") == false)
            { crearArchivoXMLAplicacion("AppConfig.xml"); }

            if (System.IO.File.Exists(directorioBaseAplicacion() +
                stringPathXMLFiles + @"\AppError.xml") == false)

            { crearArchivoXMLAplicacion("AppError.xml");

            }
        }

        #endregion  Verificación de los Archivos XML AppConfig y AppError Respectivamente

        #region Creación de los Archivos XML AppConfig y AppError Respectivamente

        /// <summary>     
        /// Creación de los Archivos XML AppConfig y AppError Respectivamente
        /// De crear el AppMessage y AppIdioms utilizar un Switch o no
        /// </summary>
        /// <param name="stringArchivoXML"></param>

        public static void crearArchivoXMLAplicacion(string
            stringParameterArchivoXML)

        {

            XmlTextWriter xmlTextwriter = new XmlTextWriter
                (directorioBaseAplicacion() + stringParameterArchivoXML,
                Encoding.UTF8);

            try
            {
                xmlTextwriter.Formatting = Formatting.Indented;
                xmlTextwriter.WriteStartDocument(false);
                if (stringParameterArchivoXML.ToLower() == "appconfig.xml")
                {
                    xmlTextwriter.WriteStartElement("configuration");
                    xmlTextwriter.WriteStartElement("aplicación");
                    xmlTextwriter.WriteElementString("nombre",
                        System.AppDomain.CurrentDomain.GetAssemblies()
                        [8].ManifestModule.Name.ToString());
                    xmlTextwriter.WriteElementString("versión",
                        System.AppDomain.CurrentDomain.GetAssemblies()
                        [8].ManifestModule.Assembly.FullName.Substring
                        (System.AppDomain.CurrentDomain.GetAssemblies()
                        [8].ManifestModule.Assembly.FullName.IndexOf("version=") +
                        8, 7));
                    xmlTextwriter.WriteElementString("ambiente",
                        System.AppDomain.CurrentDomain.GetAssemblies()
                        [8].ManifestModule.Name.IndexOf(".exe") > 0 ? "windows"
                        : "Web");
                    xmlTextwriter.WriteElementString("multiCompañía", "Si");
                    xmlTextwriter.WriteElementString("multiSucursal", "Si");
                    xmlTextwriter.WriteElementString("multiUsuario", "Si");
                    xmlTextwriter.WriteElementString("multiMoneda", "No");
                    xmlTextwriter.WriteEndElement();

                    xmlTextwriter.WriteStartElement("soporte");
                    xmlTextwriter.WriteStartElement("mensajería");
                    xmlTextwriter.WriteElementString("emailTo",
                    "colocarcontenidoaqui");
                    xmlTextwriter.WriteElementString("emailFrom",
                    "colocarcontenidoaqui");
                    xmlTextwriter.WriteElementString("emailPOP3",
                    "colocarcontenidoaqui");

                    xmlTextwriter.WriteElementString("emailSMTP",
                        "colocarcontenidoaqui");
                    xmlTextwriter.WriteElementString("hostName",
                        "colocarcontenidoaqui");
                    xmlTextwriter.WriteElementString("Password",
                        "colocarcontenidoaqui");
                    xmlTextwriter.WriteElementString("emailPort", "25");
                    xmlTextwriter.WriteElementString("emailFormat", "HTML");
                    xmlTextwriter.WriteElementString("emailSubject",
                        "Correo de Arys ERP " +
                    System.AppDomain.CurrentDomain.GetAssemblies()
                    [8].ManifestModule.Assembly.FullName.Substring
                    (System.AppDomain.CurrentDomain.GetAssemblies()
                    [8].ManifestModule.Assembly.FullName.IndexOf("version=") +
                    8, 7).ToString());
                    xmlTextwriter.WriteEndElement();
                    xmlTextwriter.WriteEndElement();

                    xmlTextwriter.WriteStartElement("manejoErrores");
                    xmlTextwriter.WriteElementString("tipoEnvio",
                    "XmlCorreo"); xmlTextwriter.WriteEndElement();

                    xmlTextwriter.WriteStartElement("connectionStrings");
                    xmlTextwriter.WriteElementString("SQLServer", "Data Source=(local); Integrated Security=true; Initial Catalog=ArysERP;");
                    xmlTextwriter.WriteElementString("default", "SQLServer");
                    xmlTextwriter.WriteEndElement();

                    xmlTextwriter.WriteEndElement();

                    xmlTextwriter.WriteEndDocument();
                    xmlTextwriter.Flush(); xmlTextwriter.Close();

                }

                if (stringParameterArchivoXML.ToLower() == "apperror.xml")
                {
                    xmlTextwriter.WriteStartElement("Configuration");
                    xmlTextwriter.WriteStartElement("Errors");

                    xmlTextwriter.WriteEndElement();
                    xmlTextwriter.WriteEndElement();

                    xmlTextwriter.WriteEndDocument();
                    xmlTextwriter.Flush();
                    xmlTextwriter.Close();
                }
            }


            catch (ArgumentException argumentException)
            {
                // Colocar Codigo para Auditar el Error y/o Enviarlo;
            }

            catch
            (UnauthorizedAccessException unauthorizedAccessException)
            {
                // Colocar Codigo para Auditar el Error y/o Enviarlo; 
            }
            catch
            (DirectoryNotFoundException directoryNotFoundException)
            {
                // Colocar Codigo para Auditar el Error y/o Enviarlo;
            }
            catch
            (Exception exception)
            {
                // Colocar Codigo para Auditar el Error y/o Enviarlo; 
            }
        }
        #endregion  Creaación de los Archivos XML AppConfig y AppError Respectivamente

        #region Envio o Escritura de Errores
        /// <summary>  
        ///Envio o Escritura de Errores
        /// MEJORAR CODIGO EN LAS PROXIMAS CLASES A POTA
        /// SOBRE TODO EN LA PARTE DE EL CURRENT DOMAINT Y LA VARIABLE QUE CONTIENE LA RUTA DE LA CARPETA XML EN EL APPCONFIG.XML
        /// </summary>  
        /// <param name="intUserID"></param>    
        /// <param name="intErrorNumber"></param>
        /// <param name="strErrorMessage"></param>
        /// <param name="strErrorDesciption"></param>  

        public static void EnviarError(int intUserID = 0, int intErrorNumber =
        0, string strErrorMessage = "", string strErrorDesciption = "")


        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\XML\\AppConfig.xml";


            XmlDocument IXmlDocument = new XmlDocument();
            IXmlDocument.Load(path);

            XmlNode nodo = IXmlDocument.SelectSingleNode("Configuration/ manejoErrores");

            string TipoEnvio = string.Format("{0}", nodo.InnerText);

            if (TipoEnvio == "XmlCorreo" || TipoEnvio == "XML")

            {    //Ruta Global
                string Ruta = System.AppDomain.CurrentDomain.BaseDirectory + @"C:\Users\DanyPC\Desktop\PrestaMe\PrestaMe\V1.0\Sources\User Interfaces\Windows\PrestaMe.Windows\XML\AppError.xml";

                XmlDocument iXmlDocument = new XmlDocument();
                XmlNode iXmlNode = default(XmlNode);
                XmlNode iXmlSubNodos = default(XmlNode);
                int intId = 0;
                try

                {
                    //cargamos el documento Xml en el fullPath.
                    iXmlDocument.Load
                   (System.AppDomain.CurrentDomain.BaseDirectory + @"..\.. \XML\AppError.xml");

                    //Seleccionamos los nodos a partir del cual escribiremos 
                    XmlNodeList iXmlNodeList = iXmlDocument.SelectNodes
                    ("Configuration/Errors/Error");

                    //Creando el Nodo Error 
                    iXmlNode = iXmlDocument.CreateElement("Error");

                    // Valor del ID 
                    intId = Convert.ToInt32(iXmlNodeList.Count.ToString());

                    // Generando el ID del Error 
                    iXmlSubNodos = iXmlDocument.CreateElement("ErrorID");
                    iXmlSubNodos.InnerText = (intId + 1).ToString();
                    iXmlNode.AppendChild(iXmlSubNodos);

                    // Creadon los Sub NODOS Adentro de el nodo Error


                    //a este no hay que madarle parametros porque cada vez que se genere da la fecha con E NOW..
                    iXmlSubNodos = iXmlDocument.CreateElement("ErrorDate");
                    iXmlSubNodos.InnerText = "Fecha: " +
                    DateTime.Now.ToShortDateString().ToString() + "  Hora: " +
                    DateTime.Now.ToShortTimeString().ToString();
                    iXmlNode.AppendChild(iXmlSubNodos);

                    //Creandoel nodo del UserID    
                    iXmlSubNodos = iXmlDocument.CreateElement("UserID");
                    iXmlSubNodos.InnerText = intUserID.ToString();
                    iXmlNode.AppendChild(iXmlSubNodos);

                    //Creandoel nodo del ErrorNumber    
                    iXmlSubNodos = iXmlDocument.CreateElement("ErrorNumber");
                    iXmlSubNodos.InnerText = intErrorNumber.ToString();
                    iXmlNode.AppendChild(iXmlSubNodos);

                    //Creando el nodo del ErrorMessage   
                    iXmlSubNodos = iXmlDocument.CreateElement("ErrorMessage");
                    iXmlSubNodos.InnerText = strErrorMessage.ToString();
                    iXmlNode.AppendChild(iXmlSubNodos);

                    //Creandoel nodo del ErrorDescripcion para describir   
                    iXmlSubNodos = iXmlDocument.CreateElement
                        ("ErrorDescripcion");
                    iXmlSubNodos.InnerText = strErrorDesciption.ToString();
                    iXmlNode.AppendChild(iXmlSubNodos);

                    //importante para escribrir dentro de <Errores>
                    iXmlDocument.DocumentElement.SelectSingleNode
                        ("Errors").AppendChild(iXmlNode);

                    // Gurdando los cambios en el AppErrors.xml     
                    iXmlDocument.Save
                   (System.AppDomain.CurrentDomain.BaseDirectory + @"..\.. \XML\AppError.xml");
                }
                catch (Exception iException)

                {
                    // Colocar Codigo para Auditar el Error y/o Enviarlo;
                }
            }
            if (TipoEnvio == "XmlCorreo") { EnviarMail(""); }

        }

        #endregion

        #region Envio de Errores y Excepciones por Mail

        /// <summary> 
        /// Envio de Errores y Excepciones por Mail
        /// </summary>   
        /// <param name="Error"></param>
        public static void EnviarMail(string Error)

        {
            XmlDocument ixmldocument = new XmlDocument();
            string path = System.AppDomain.CurrentDomain.BaseDirectory + @".. \..\XML\AppConfig.xml";
            ixmldocument.Load(path);

            #region Nodos De Configuracion Del Correo

            #region   Buscar los Nodos, SubNodos y Propiedades Correspondientes Existentes en el AppCoinfig

            XmlNode To = ixmldocument.SelectSingleNode("Configuration/Suport/ emailTo");
            XmlNode From = ixmldocument.SelectSingleNode("Configuration/ Suport/emailFrom");
            XmlNode POP3 = ixmldocument.SelectSingleNode("Configuration/Suport/emailPOP3");
            XmlNode SMTP = ixmldocument.SelectSingleNode("Configuration/ Suport/emailSMTP");
            XmlNode host = ixmldocument.SelectSingleNode("Configuration/ Suport/host");
            XmlNode password = ixmldocument.SelectSingleNode("Configuration/ Suport/Password");
            XmlNode port = ixmldocument.SelectSingleNode("Configuration/ Suport/emailPort");
            XmlNode Format = ixmldocument.SelectSingleNode("Configuration/ Suport/emailFormat");
            XmlNode Subject = ixmldocument.SelectSingleNode("Configuration/ Suport/emailSubject");

            #endregion  Buscar los Nodos, SubNodos y Propiedades Correspondientes Existentes en el AppCoinfig

            string StringTo = string.Format("{0}", To.InnerText),
                StringFrom = string.Format("{0}", From.InnerText),
                StringPOP3 = string.Format("{0}", POP3.InnerText),
                StringSMTP = string.Format("{0}", SMTP.InnerText),
                StringHost = string.Format("{0}", host.InnerText),
                StringPassword = string.Format("{0}", password.InnerText),
                StringPort = string.Format("{0}", port.InnerText),
                StringFormat = string.Format("{0}", Format.InnerText),
                StringSubject = string.Format("{0}", Subject.InnerText);

            #endregion

            MailMessage IMailMessage = new MailMessage(StringTo, StringFrom,
                "Mensage De Error Grupo MaxDev", Error);
            SmtpClient ISmtpClient = new SmtpClient("smtp.live.com");
            ISmtpClient.Credentials = new System.Net.NetworkCredential
                (StringTo, StringPassword);

            //ISmtpClient.EnableSsl = true; 

            try
            {
                ISmtpClient.Send(IMailMessage);
            }
            catch (Exception iExeption)
            {
                // Colocar Codigo para Auditar el Error y/o Enviarlo;
            }
        }

        #endregion

        #region Determinar Conexion Según Parámetros ConexionStrings
        /// <summary> 
        /// 
        /// </summary> 
        /// <returns></returns> 

        public static string determinarConexionFromXMLFile()
        {
            string stringDB = string.Empty;

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(directorioBaseAplicacion() + stringPathXMLFiles +
                @"\AppConfig.xml");

            XmlNode xmlNode = xmlDocument.SelectSingleNode("Configuration/ connectionStrings");

            if (xmlNode.InnerXml.ToUpper().IndexOf("SQLSERVER") > 0)
            {
                stringDB = "SQLServer";

            }
            else
            {
                if (xmlNode.InnerXml.ToUpper().IndexOf("ORACLE") > 0) {
                    stringDB = "Oracle";

                }
                else { if (xmlNode.InnerXml.ToUpper().IndexOf("MYSQL") > 0) {
                        stringDB = "MySQL";
                    }
                    else
                    {
                        if (xmlNode.InnerXml.ToUpper().IndexOf("SQLLITE") > 0)
                        { stringDB = "SQLLite"; }

                        else

                        {
                            if (xmlNode.InnerXml.ToUpper().IndexOf("POSTGRESQL") > 0)

                            {
                                stringDB = "PostgreSQL";
                            }

                            else {
                            }
                        }
                    }
                }
            }

            return string.Format("{0}", stringDB);

        }

        #endregion  Determinar Conexion Según Parámetros ConexionStrings

        #region   Abrir Conexion Según Parámetros ConexionStrings

        /// <summary> 
        /// Abrir Conexion Según Parámetros ConexionStrings 
        /// </summary>  
        /// <returns></returns> 
        public static string abrirConexionFromXMLFile(string paramConexion = "")

        {
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(directorioBaseAplicacion() + stringPathXMLFiles + @"\AppConfig.xml");


            XmlNode xmlNode;

            switch (paramConexion.ToUpper())

            {
                case "SQLSERVER":
                    {
                        xmlNode = xmlDocument.SelectSingleNode("Configuration/connectionStrings/SQLServer");
                        break;
                    } case "ORACLE":

                    {
                        xmlNode = xmlDocument.SelectSingleNode("Configuration/connectionStrings/Oracle");
                        break;
                    }
                case "MYSQL":
                    { xmlNode = xmlDocument.SelectSingleNode("Configuration/connectionStrings/MySQL");
                        break;
                    } case "SQLLITE":
                    {
                        xmlNode = xmlDocument.SelectSingleNode("Configuration/connectionStrings/SQLLite");
                        break;
                    }
                case "POSTGRESQL":
                    { xmlNode = xmlDocument.SelectSingleNode("Configuration/connectionStrings/PostgreSQL");
                        break; }
                default:
                    {
                        xmlNode = xmlDocument.SelectSingleNode("Configuration/connectionStrings/SQLServer");
                        break;
                    }
            }

            return string.Format("{0}", xmlNode.InnerText);

        }

        #endregion  Abrir Conexion Según Parámetros ConexionStrings

        #region   Determinar El Contenido de Un Nodo Especificado

        /// <summary> 
        /// Determinar El Contenido de Un Nodo Especificado
        /// </summary>
        /// <param name="stringParameterXMLFile">a</param> 
        /// <param name="stringParameterNodo">b</param>
        /// <param name="stringParameterAtributo">c</param> 
        /// <returns></returns>

        public static string buscarNodoArchivoXML(string stringParameterXMLFile, string stringParameterNodo, string stringParameterAtributo = "")

        {
            stringPathXMLFiles = string.IsNullOrEmpty(stringPathXMLFiles) ?
                "XML" : stringPathXMLFiles.ToString();
            stringParameterXMLFile = string.IsNullOrEmpty
                (stringParameterXMLFile) ? "AppConfig.XML" :
                stringParameterXMLFile.ToString();

            XmlNodeList xmlNodeList = default(XmlNodeList);
            XmlDocument xmlDocument = new XmlDocument();

            xmlDocument.Load(directorioBaseAplicacion() + stringPathXMLFiles +
                @"\" + stringParameterXMLFile.ToString());
            xmlNodeList = xmlDocument.GetElementsByTagName
                (stringParameterNodo);

            return string.IsNullOrEmpty(stringParameterAtributo) ? xmlNodeList
                [0].InnerText : xmlNodeList[0].Attributes
                [stringParameterAtributo].InnerText;

        }
        #endregion  Determinar El Contenido de Un Nodo Especificado

        #region   Determinar Un Nodo Especificado

        /// <summary>  
        /// </summary>  
        /// <returns></returns> 
        public static XmlNode determinarNodoXML(string paramXMLFile, string
            paramNodo)

        {
            XmlDocument oXmlDocument = new XmlDocument();
            oXmlDocument.Load(directorioBaseAplicacion() + @"XML\" +
                paramXMLFile);

            XmlNode oXmlNode = oXmlDocument.SelectSingleNode(paramNodo);

            return oXmlNode;

        }

        #endregion  Determinar Un Nodo Especificado

        #region    Anclaje de Objetos

        /// <summary>
        ///  Función de Anclaje de Objetos
        /// </summary>
        /// <param name="stringParameterDockStyle"></param>
        /// <returns></returns>


        public static DockStyle dockStyle(string stringParameterDockStyle)
        {
            DockStyle dockStyle = new DockStyle();



            switch (stringParameterDockStyle.ToLower())
            {
                case "bottom":
                    {
                        dockStyle = DockStyle.Bottom;
                        break;
                    }
                case "top":
                    {
                        dockStyle = DockStyle.Top;
                        break;
                    }
                case "left":
                    {
                        dockStyle = DockStyle.Left;
                        break;
                    }
                case "right":
                    {
                        dockStyle = DockStyle.Right;
                        break;
                    }
                case "fill":
                    {
                        dockStyle = DockStyle.Fill;
                        break;
                    }
                case "none":
                    {
                        dockStyle = DockStyle.None;
                        break;
                    }
            }
            return dockStyle;
        }

        #endregion Anclaje de Objetos

        #region    Reajuste de Objetos Según Perspectiva

        /// <summary>
        /// Función de Reajuste de Objetos Según Perspectiva
        /// </summary>  
        /// <param name="stringParameterDockStyle"></param>
        /// <returns></returns>


        public static AnchorStyles anchorStyles(string stringParameterAnchorStyles)

        {   // Declaración de Variables a Ser Utilizadas
            AnchorStyles anchorStyles = new AnchorStyles();

            // Lógica Principal

            switch (stringParameterAnchorStyles.ToLower())

            {

                case "bottom": {

                        anchorStyles = AnchorStyles.Bottom;
                        break;
                    }
                case "top": {

                        anchorStyles = AnchorStyles.Top;
                        break;
                    }
                case "left": {

                        anchorStyles = AnchorStyles.Left;
                        break;
                    } case "right": {
                        anchorStyles = AnchorStyles.Right;
                        break;
                    } case "none": {

                        anchorStyles = AnchorStyles.None;
                        break;
                    }
            }

            return anchorStyles;

        }

        #endregion Reajuste de Objetos Según Perspectiva

        #region    Obtener y Devolver el Hash de un Texto Especificado

        /// <summary> 
        /// Función para Obtener y Devolver el Hash de un Texto Especificado
        /// </summary> 
        /// <param name="stringParameterText">Texto a Ser Convertido en Formato HASH</param> 
        /// <param name="hashTypeParameter">Tipo de Hash:  MD5, SHA1, SHA128,
        /// SHA256, SHA384, SHA512, SHA634.  Default MD5</param>  
        /// <returns></returns> 
        /// 
        public static string getHash(string stringParameterText, hashType hashTypeParameter = hashType.MD5)

        {
            // Declaración de Variables, Constantes, Instancias y Objetos Locales a Ser Utiizadas 

            string stringHash = string.Empty;

            UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

            byte[] byteHashValue;
            byte[] byteText = unicodeEncoding.GetBytes(stringParameterText);

            // Lógica Principal   
            switch (hashTypeParameter) {

                case hashType.MD5:
                    {
                        MD5 md5HashString = new MD5CryptoServiceProvider();
                        byteHashValue = md5HashString.ComputeHash(byteText);
                        foreach (byte byteValue in byteHashValue)
                        {
                            stringHash += String.Format("{0:x2}", byteValue);
                        }

                        break;
                    }
                case hashType.SHA1:
                    {
                        SHA1Managed sha1HashString = new SHA1Managed();

                        byteHashValue = sha1HashString.ComputeHash(byteText);
                        foreach (byte byteValue in byteHashValue)
                        {
                            stringHash += String.Format("{0:x2}", byteValue);
                        }
                        break;

                    }
                case hashType.SHA128:
                    {
                        SHA1Managed sha128HashString = new SHA1Managed();

                        byteHashValue = sha128HashString.ComputeHash
                        (byteText);
                        foreach (byte byteValue in byteHashValue)
                        {
                            stringHash += String.Format("{0:x2}", byteValue);
                        }
                        break;

                    }
                case hashType.SHA256:
                    {
                        SHA256Managed sha256HashString = new SHA256Managed();

                        byteHashValue = sha256HashString.ComputeHash
                        (byteText);


                        foreach (byte bytevalue in byteHashValue)

                        {

                            stringHash += String.Format("{0:x2}", bytevalue);

                        }

                        break;
                    }
                case hashType.SHA384:
                    {
                        SHA384Managed sha384HashString = new SHA384Managed();

                        byteHashValue = sha384HashString.ComputeHash
                        (byteText);

                        foreach (byte byteValue in byteHashValue)
                        {
                            stringHash += String.Format("{0:x2}", byteValue);
                        }

                        break;
                    }
                case hashType.SHA512:
                    {
                        SHA512Managed sha512HashString = new SHA512Managed();

                        byteHashValue = sha512HashString.ComputeHash

                            (byteText);

                        foreach (byte byteValue in byteHashValue)

                        {
                            stringHash += String.Format("{0:x2}", byteValue);
                        }
                        break;

                    }
                case hashType.SHA634:

                    {
                        break;
                    }
                default: {
                        stringHash = "Tipo de Hash Inválio";
                        break;
                    }
            }

            // Resultado de la Función 

            return stringHash;
        }
    

        #endregion Obtener y Devolver el Hash de un Texto Especificado

        #region    Verificar String vs String Hash

        /// <summary> 
        /// Función para Verificar String vs String Hash 
        /// </summary>
        /// <param name="stringHashParameter">Texto en Formato Hash a Comparar</param> 
        /// <param name="hashTypeParameter">Tipo de Hash:  MD5, SHA1, SHA128,
        /// SHA256, SHA384, SHA512, SHA634.  Default MD5</param> 
        /// <returns></returns> 

        public static bool checkHash(string stringTextParameter, string
            stringHashParameter, hashType hashTypeParameter = hashType.MD5)

        {
            return (getHash(stringTextParameter, hashTypeParameter) == 
                stringHashParameter);
        }

        #endregion Verificar String vs String Hash
    }
        #endregion     Clase Global, Contenedora de los Procedimientos, Funciones, Eventos y Propiedades de la Aplicacion
}
       #endregion     Logica de la Clase, Según NameSpace Especificado


