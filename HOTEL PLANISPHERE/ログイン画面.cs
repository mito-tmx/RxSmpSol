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

namespace HOTEL_PLANISPHERE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ログイン画面 recording.
    /// </summary>
    [TestModule("ed49ad44-e0d7-4cfe-b4ee-4b5de73b870a", ModuleType.Recording, 1)]
    public partial class ログイン画面 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HOTEL_PLANISPHERERepository repository.
        /// </summary>
        public static HOTEL_PLANISPHERERepository repo = HOTEL_PLANISPHERERepository.Instance;

        static ログイン画面 instance = new ログイン画面();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ログイン画面()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ログイン画面 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ログイン画面.Email' at 165;24.", repo.ApplicationUnderTest.ログイン画面.EmailInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ログイン画面.Email.Click("165;24");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ichiro@example.com' with focus on 'ApplicationUnderTest.ログイン画面.Email'.", repo.ApplicationUnderTest.ログイン画面.EmailInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.ログイン画面.Email.PressKeys("ichiro@example.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ログイン画面.Password' at 147;27.", repo.ApplicationUnderTest.ログイン画面.PasswordInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ログイン画面.Password.Click("147;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'password' with focus on 'ApplicationUnderTest.ログイン画面.Password'.", repo.ApplicationUnderTest.ログイン画面.PasswordInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.ログイン画面.Password.PressKeys("password");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ログイン画面.LoginButton' at 212;9.", repo.ApplicationUnderTest.ログイン画面.LoginButtonInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.ログイン画面.LoginButton.Click("212;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='一般会員') on item 'ApplicationUnderTest.ログイン画面.Rank'.", repo.ApplicationUnderTest.ログイン画面.RankInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.ログイン画面.RankInfo, "InnerText", "一般会員", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.Always});
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
