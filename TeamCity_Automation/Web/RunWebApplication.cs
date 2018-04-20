﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TeamCity_Automation.Web
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RunWebApplication recording.
    /// </summary>
    [TestModule("18088c17-8437-42dc-bca2-bab4f12bd340", ModuleType.Recording, 1)]
    public partial class RunWebApplication : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TeamCity_Automation.TeamCity_AutomationRepository repository.
        /// </summary>
        public static TeamCity_Automation.TeamCity_AutomationRepository repo = TeamCity_Automation.TeamCity_AutomationRepository.Instance;

        static RunWebApplication instance = new RunWebApplication();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RunWebApplication()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RunWebApplication Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.ranorex.com/web-testing-examples/vip/' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.ranorex.com/web-testing-examples/vip/", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
