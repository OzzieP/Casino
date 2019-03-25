﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Ce code a été généré par un générateur de test codé de l'interface utilisateur.
//      Version : 15.0.0.0 
//
//      Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//      le code est régénéré.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Générateur de test codé de l\'interface utilisateur", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Ajout de crédits d'un montant de 10 au solde du joueur
        /// </summary>
        public void RecordedAjouterArgent()
        {
            #region Variable Declarations
            WinWindow uIAjouterdelargentWindow = this.UIForm1Window.UIForm1Client.UIAjouterdelargentWindow;
            #endregion

            // Clic 'Ajouter de l'argent' fenêtre
            Mouse.Click(uIAjouterdelargentWindow, new Point(884, 710));
        }
        
        /// <summary>
        /// Vérifie que l'affichage du solde a été mis à jour suite au clique sur le bouton "Ajouter de l'argent"
        /// </summary>
        public void AssertSoldeEgalA110()
        {
            #region Variable Declarations
            WinWindow uIItem100Window = this.UIForm1Window.UIForm1Client.UIItem100Window;
            #endregion

            // Vérifier que la propriété 'Name' de '100' fenêtre est égal à '110'
            Assert.AreEqual(this.AssertSoldeEgalA110ExpectedValues.UIItem100WindowName, uIItem100Window.Name, "Le solde du joueur doit être égal à 110");
        }
        
        /// <summary>
        /// AssertMethod1 - Utilisez 'AssertMethod1ExpectedValues' pour passer les paramètres dans cette méthode.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            WinWindow uIItem100Window = this.UIForm1Window.UIForm1Client.UIItem100Window;
            #endregion

            // Vérifier que la propriété 'ClassName' de '100' fenêtre est égal à 'WindowsForms10.STATIC.app.0.141b42a_r10_ad1'
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIItem100WindowClassName, uIItem100Window.ClassName, "test");
        }
        
        #region Properties
        public virtual AssertSoldeEgalA110ExpectedValues AssertSoldeEgalA110ExpectedValues
        {
            get
            {
                if ((this.mAssertSoldeEgalA110ExpectedValues == null))
                {
                    this.mAssertSoldeEgalA110ExpectedValues = new AssertSoldeEgalA110ExpectedValues();
                }
                return this.mAssertSoldeEgalA110ExpectedValues;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public UIForm1Window UIForm1Window
        {
            get
            {
                if ((this.mUIForm1Window == null))
                {
                    this.mUIForm1Window = new UIForm1Window();
                }
                return this.mUIForm1Window;
            }
        }
        #endregion
        
        #region Fields
        private AssertSoldeEgalA110ExpectedValues mAssertSoldeEgalA110ExpectedValues;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private UIForm1Window mUIForm1Window;
        #endregion
    }
    
    /// <summary>
    /// Paramètres à passer dans 'AssertSoldeEgalA110'
    /// </summary>
    [GeneratedCode("Générateur de test codé de l\'interface utilisateur", "15.0.26208.0")]
    public class AssertSoldeEgalA110ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Vérifier que la propriété 'Name' de '100' fenêtre est égal à '110'
        /// </summary>
        public string UIItem100WindowName = "110";
        #endregion
    }
    
    /// <summary>
    /// Paramètres à passer dans 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Générateur de test codé de l\'interface utilisateur", "15.0.26208.0")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Vérifier que la propriété 'ClassName' de '100' fenêtre est égal à 'WindowsForms10.STATIC.app.0.141b42a_r10_ad1'
        /// </summary>
        public string UIItem100WindowClassName = "WindowsForms10.STATIC.app.0.141b42a_r10_ad1";
        #endregion
    }
    
    [GeneratedCode("Générateur de test codé de l\'interface utilisateur", "15.0.26208.0")]
    public class UIForm1Window : WinWindow
    {
        
        public UIForm1Window()
        {
            #region Critères de recherche
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Form1";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public UIForm1Client UIForm1Client
        {
            get
            {
                if ((this.mUIForm1Client == null))
                {
                    this.mUIForm1Client = new UIForm1Client(this);
                }
                return this.mUIForm1Client;
            }
        }
        
        public UITextBox1Window UITextBox1Window
        {
            get
            {
                if ((this.mUITextBox1Window == null))
                {
                    this.mUITextBox1Window = new UITextBox1Window(this);
                }
                return this.mUITextBox1Window;
            }
        }
        #endregion
        
        #region Fields
        private UIForm1Client mUIForm1Client;
        
        private UITextBox1Window mUITextBox1Window;
        #endregion
    }
    
    [GeneratedCode("Générateur de test codé de l\'interface utilisateur", "15.0.26208.0")]
    public class UIForm1Client : WinClient
    {
        
        public UIForm1Client(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Critères de recherche
            this.SearchProperties[WinControl.PropertyNames.Name] = "Form1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinWindow UITextBox1Window
        {
            get
            {
                if ((this.mUITextBox1Window == null))
                {
                    this.mUITextBox1Window = new WinWindow(this);
                    #region Critères de recherche
                    this.mUITextBox1Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
                    this.mUITextBox1Window.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITextBox1Window;
            }
        }
        
        public WinWindow UIJOUERWindow
        {
            get
            {
                if ((this.mUIJOUERWindow == null))
                {
                    this.mUIJOUERWindow = new WinWindow(this);
                    #region Critères de recherche
                    this.mUIJOUERWindow.SearchProperties[WinWindow.PropertyNames.Name] = "JOUER";
                    this.mUIJOUERWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains));
                    this.mUIJOUERWindow.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIJOUERWindow;
            }
        }
        
        public WinWindow UIItem100Window
        {
            get
            {
                if ((this.mUIItem100Window == null))
                {
                    this.mUIItem100Window = new WinWindow(this);
                    #region Critères de recherche
                    this.mUIItem100Window.SearchProperties[WinWindow.PropertyNames.Name] = "100";
                    this.mUIItem100Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.STATIC", PropertyExpressionOperator.Contains));
                    this.mUIItem100Window.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIItem100Window;
            }
        }
        
        public WinWindow UIAjouterdelargentWindow
        {
            get
            {
                if ((this.mUIAjouterdelargentWindow == null))
                {
                    this.mUIAjouterdelargentWindow = new WinWindow(this);
                    #region Critères de recherche
                    this.mUIAjouterdelargentWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Ajouter de l\'argent";
                    this.mUIAjouterdelargentWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains));
                    this.mUIAjouterdelargentWindow.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIAjouterdelargentWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUITextBox1Window;
        
        private WinWindow mUIJOUERWindow;
        
        private WinWindow mUIItem100Window;
        
        private WinWindow mUIAjouterdelargentWindow;
        #endregion
    }
    
    [GeneratedCode("Générateur de test codé de l\'interface utilisateur", "15.0.26208.0")]
    public class UITextBox1Window : WinWindow
    {
        
        public UITextBox1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Critères de recherche
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "textBox1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UITextBox1Edit
        {
            get
            {
                if ((this.mUITextBox1Edit == null))
                {
                    this.mUITextBox1Edit = new WinEdit(this);
                    #region Critères de recherche
                    this.mUITextBox1Edit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITextBox1Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITextBox1Edit;
        #endregion
    }
}