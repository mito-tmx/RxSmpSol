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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace HOTEL_PLANISPHERE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the HOTEL_PLANISPHERERepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("dc4b6f21-9a6a-47ac-836a-f9db4a327463")]
    public partial class HOTEL_PLANISPHERERepository : RepoGenBaseFolder
    {
        static HOTEL_PLANISPHERERepository instance = new HOTEL_PLANISPHERERepository();
        HOTEL_PLANISPHERERepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the HOTEL_PLANISPHERERepository element repository.
        /// </summary>
        [RepositoryFolder("dc4b6f21-9a6a-47ac-836a-f9db4a327463")]
        public static HOTEL_PLANISPHERERepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public HOTEL_PLANISPHERERepository() 
            : base("HOTEL_PLANISPHERERepository", "/", null, 0, false, "dc4b6f21-9a6a-47ac-836a-f9db4a327463", ".\\RepositoryImages\\HOTEL_PLANISPHERERepositorydc4b6f21.rximgres")
        {
            _applicationundertest = new HOTEL_PLANISPHERERepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

        string _menuName = "";

        /// <summary>
        /// Gets or sets the value of variable menuName.
        /// </summary>
        [TestVariable("9bfb6113-ad43-4745-860e-7e6241a2c268")]
        public string menuName
        {
            get { return _menuName; }
            set { _menuName = value; }
        }

        string _planName = "このプランで予約";

        /// <summary>
        /// Gets or sets the value of variable planName.
        /// </summary>
        [TestVariable("6ce347a3-d342-4944-899d-47edd97e4d02")]
        public string planName
        {
            get { return _planName; }
            set { _planName = value; }
        }

        string _date = "25";

        /// <summary>
        /// Gets or sets the value of variable date.
        /// </summary>
        [TestVariable("eb19ba77-4143-4fc6-bc7f-5e7a47907140")]
        public string date
        {
            get { return _date; }
            set { _date = value; }
        }

        string _addPlan = "breakfast";

        /// <summary>
        /// Gets or sets the value of variable addPlan.
        /// </summary>
        [TestVariable("ccd51d0f-a943-49e3-96b6-975d9bbbbf3e")]
        public string addPlan
        {
            get { return _addPlan; }
            set { _addPlan = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("dc4b6f21-9a6a-47ac-836a-f9db4a327463")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("8031bf8e-3d21-4601-9aa5-8b4519170e96")]
        public virtual HOTEL_PLANISPHERERepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class HOTEL_PLANISPHERERepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("8031bf8e-3d21-4601-9aa5-8b4519170e96")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            HOTEL_PLANISPHERERepositoryFolders.トップページFolder _トップページ;
            HOTEL_PLANISPHERERepositoryFolders.ログイン画面Folder _ログイン画面;
            HOTEL_PLANISPHERERepositoryFolders.宿泊プラン一覧Folder _宿泊プラン一覧;
            HOTEL_PLANISPHERERepositoryFolders.宿泊予約画面Folder _宿泊予約画面;
            HOTEL_PLANISPHERERepositoryFolders.宿泊予約確認画面Folder _宿泊予約確認画面;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='hotel-example-site.takeyaqa.dev']", parentFolder, 30000, null, false, "8031bf8e-3d21-4601-9aa5-8b4519170e96", "")
            {
                _トップページ = new HOTEL_PLANISPHERERepositoryFolders.トップページFolder(this);
                _ログイン画面 = new HOTEL_PLANISPHERERepositoryFolders.ログイン画面Folder(this);
                _宿泊プラン一覧 = new HOTEL_PLANISPHERERepositoryFolders.宿泊プラン一覧Folder(this);
                _宿泊予約画面 = new HOTEL_PLANISPHERERepositoryFolders.宿泊予約画面Folder(this);
                _宿泊予約確認画面 = new HOTEL_PLANISPHERERepositoryFolders.宿泊予約確認画面Folder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8031bf8e-3d21-4601-9aa5-8b4519170e96")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8031bf8e-3d21-4601-9aa5-8b4519170e96")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The トップページ folder.
            /// </summary>
            [RepositoryFolder("b0e1df74-b581-47ba-a44f-ede5a145e237")]
            public virtual HOTEL_PLANISPHERERepositoryFolders.トップページFolder トップページ
            {
                get { return _トップページ; }
            }

            /// <summary>
            /// The ログイン画面 folder.
            /// </summary>
            [RepositoryFolder("17077cf9-7edc-4c6a-acb0-03ba8e2687e0")]
            public virtual HOTEL_PLANISPHERERepositoryFolders.ログイン画面Folder ログイン画面
            {
                get { return _ログイン画面; }
            }

            /// <summary>
            /// The 宿泊プラン一覧 folder.
            /// </summary>
            [RepositoryFolder("8c811a61-602d-4504-b2ae-ee89aa5b05fc")]
            public virtual HOTEL_PLANISPHERERepositoryFolders.宿泊プラン一覧Folder 宿泊プラン一覧
            {
                get { return _宿泊プラン一覧; }
            }

            /// <summary>
            /// The 宿泊予約画面 folder.
            /// </summary>
            [RepositoryFolder("35c6ba23-522c-4021-842d-4e8c89ceb27f")]
            public virtual HOTEL_PLANISPHERERepositoryFolders.宿泊予約画面Folder 宿泊予約画面
            {
                get { return _宿泊予約画面; }
            }

            /// <summary>
            /// The 宿泊予約確認画面 folder.
            /// </summary>
            [RepositoryFolder("cec01dd7-f130-47b9-9b60-43c59dca8d63")]
            public virtual HOTEL_PLANISPHERERepositoryFolders.宿泊予約確認画面Folder 宿泊予約確認画面
            {
                get { return _宿泊予約確認画面; }
            }
        }

        /// <summary>
        /// The トップページFolder folder.
        /// </summary>
        [RepositoryFolder("b0e1df74-b581-47ba-a44f-ede5a145e237")]
        public partial class トップページFolder : RepoGenBaseFolder
        {
            RepoItemInfo _メニューボタンInfo;
            RepoItemInfo _ログアウトInfo;

            /// <summary>
            /// Creates a new トップページ  folder.
            /// </summary>
            public トップページFolder(RepoGenBaseFolder parentFolder) :
                    base("トップページ", "", parentFolder, 0, null, false, "b0e1df74-b581-47ba-a44f-ede5a145e237", "")
            {
                _メニューボタンInfo = new RepoItemInfo(this, "メニューボタン", ".//?/a[@innertext=$menuName]", "", 30000, null, "0a644c8d-4ce9-4377-b38e-1562fcdabe26");
                _ログアウトInfo = new RepoItemInfo(this, "ログアウト", ".//form[#'logout-form']/button[@innertext='ログアウト']", "", 30000, null, "cbaabced-8baa-4dad-90b5-cc5b48a5cae6");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b0e1df74-b581-47ba-a44f-ede5a145e237")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The メニューボタン item.
            /// </summary>
            [RepositoryItem("0a644c8d-4ce9-4377-b38e-1562fcdabe26")]
            public virtual Ranorex.ATag メニューボタン
            {
                get
                {
                    return _メニューボタンInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The メニューボタン item info.
            /// </summary>
            [RepositoryItemInfo("0a644c8d-4ce9-4377-b38e-1562fcdabe26")]
            public virtual RepoItemInfo メニューボタンInfo
            {
                get
                {
                    return _メニューボタンInfo;
                }
            }

            /// <summary>
            /// The ログアウト item.
            /// </summary>
            [RepositoryItem("cbaabced-8baa-4dad-90b5-cc5b48a5cae6")]
            public virtual Ranorex.ButtonTag ログアウト
            {
                get
                {
                    return _ログアウトInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The ログアウト item info.
            /// </summary>
            [RepositoryItemInfo("cbaabced-8baa-4dad-90b5-cc5b48a5cae6")]
            public virtual RepoItemInfo ログアウトInfo
            {
                get
                {
                    return _ログアウトInfo;
                }
            }
        }

        /// <summary>
        /// The ログイン画面Folder folder.
        /// </summary>
        [RepositoryFolder("17077cf9-7edc-4c6a-acb0-03ba8e2687e0")]
        public partial class ログイン画面Folder : RepoGenBaseFolder
        {
            RepoItemInfo _emailInfo;
            RepoItemInfo _passwordInfo;
            RepoItemInfo _loginbuttonInfo;
            RepoItemInfo _rankInfo;

            /// <summary>
            /// Creates a new ログイン画面  folder.
            /// </summary>
            public ログイン画面Folder(RepoGenBaseFolder parentFolder) :
                    base("ログイン画面", "", parentFolder, 0, null, false, "17077cf9-7edc-4c6a-acb0-03ba8e2687e0", "")
            {
                _emailInfo = new RepoItemInfo(this, "Email", ".//input[#'email']", "", 30000, null, "6ea14845-6780-4215-8c61-bf7375ecaca4");
                _passwordInfo = new RepoItemInfo(this, "Password", ".//input[#'password']", "", 30000, null, "93d22625-1350-4578-832c-49ff27f9cc65");
                _loginbuttonInfo = new RepoItemInfo(this, "LoginButton", ".//button[#'login-button']", "", 30000, null, "10e24511-1230-44e0-888d-7709fca939ee");
                _rankInfo = new RepoItemInfo(this, "Rank", ".//p[#'rank']", "", 30000, null, "d9187b66-610e-4a65-a4e9-f402d1bdb16c");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("17077cf9-7edc-4c6a-acb0-03ba8e2687e0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Email item.
            /// </summary>
            [RepositoryItem("6ea14845-6780-4215-8c61-bf7375ecaca4")]
            public virtual Ranorex.InputTag Email
            {
                get
                {
                    return _emailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Email item info.
            /// </summary>
            [RepositoryItemInfo("6ea14845-6780-4215-8c61-bf7375ecaca4")]
            public virtual RepoItemInfo EmailInfo
            {
                get
                {
                    return _emailInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("93d22625-1350-4578-832c-49ff27f9cc65")]
            public virtual Ranorex.InputTag Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("93d22625-1350-4578-832c-49ff27f9cc65")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The LoginButton item.
            /// </summary>
            [RepositoryItem("10e24511-1230-44e0-888d-7709fca939ee")]
            public virtual Ranorex.ButtonTag LoginButton
            {
                get
                {
                    return _loginbuttonInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The LoginButton item info.
            /// </summary>
            [RepositoryItemInfo("10e24511-1230-44e0-888d-7709fca939ee")]
            public virtual RepoItemInfo LoginButtonInfo
            {
                get
                {
                    return _loginbuttonInfo;
                }
            }

            /// <summary>
            /// The Rank item.
            /// </summary>
            [RepositoryItem("d9187b66-610e-4a65-a4e9-f402d1bdb16c")]
            public virtual Ranorex.PTag Rank
            {
                get
                {
                    return _rankInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The Rank item info.
            /// </summary>
            [RepositoryItemInfo("d9187b66-610e-4a65-a4e9-f402d1bdb16c")]
            public virtual RepoItemInfo RankInfo
            {
                get
                {
                    return _rankInfo;
                }
            }
        }

        /// <summary>
        /// The 宿泊プラン一覧Folder folder.
        /// </summary>
        [RepositoryFolder("8c811a61-602d-4504-b2ae-ee89aa5b05fc")]
        public partial class 宿泊プラン一覧Folder : RepoGenBaseFolder
        {
            RepoItemInfo _このプランで予約Info;

            /// <summary>
            /// Creates a new 宿泊プラン一覧  folder.
            /// </summary>
            public 宿泊プラン一覧Folder(RepoGenBaseFolder parentFolder) :
                    base("宿泊プラン一覧", "", parentFolder, 0, null, false, "8c811a61-602d-4504-b2ae-ee89aa5b05fc", "")
            {
                _このプランで予約Info = new RepoItemInfo(this, "このプランで予約", ".//div[#'plan-list']//h5[@innertext=$planName]/../a[@innertext='このプランで予約']", "", 30000, null, "b7ea1b87-f3dc-4966-8773-c6453adccc7e");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8c811a61-602d-4504-b2ae-ee89aa5b05fc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The このプランで予約 item.
            /// </summary>
            [RepositoryItem("b7ea1b87-f3dc-4966-8773-c6453adccc7e")]
            public virtual Ranorex.ATag このプランで予約
            {
                get
                {
                    return _このプランで予約Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The このプランで予約 item info.
            /// </summary>
            [RepositoryItemInfo("b7ea1b87-f3dc-4966-8773-c6453adccc7e")]
            public virtual RepoItemInfo このプランで予約Info
            {
                get
                {
                    return _このプランで予約Info;
                }
            }
        }

        /// <summary>
        /// The 宿泊予約画面Folder folder.
        /// </summary>
        [RepositoryFolder("35c6ba23-522c-4021-842d-4e8c89ceb27f")]
        public partial class 宿泊予約画面Folder : RepoGenBaseFolder
        {
            RepoItemInfo _dateInfo;
            RepoItemInfo _termInfo;
            RepoItemInfo _headcountInfo;
            RepoItemInfo _breakfastInfo;
            RepoItemInfo _contactInfo;
            RepoItemInfo _submitbuttonInfo;
            RepoItemInfo _atag25Info;

            /// <summary>
            /// Creates a new 宿泊予約画面  folder.
            /// </summary>
            public 宿泊予約画面Folder(RepoGenBaseFolder parentFolder) :
                    base("宿泊予約画面", "", parentFolder, 0, null, false, "35c6ba23-522c-4021-842d-4e8c89ceb27f", "")
            {
                _dateInfo = new RepoItemInfo(this, "Date", ".//input[#'date']", "", 30000, null, "82329a64-36c3-4883-9ae4-af756816b6f4");
                _termInfo = new RepoItemInfo(this, "Term", ".//input[#'term']", "", 30000, null, "fb587ea8-54f9-480d-9f2f-69789cb9f385");
                _headcountInfo = new RepoItemInfo(this, "HeadCount", ".//input[#'head-count']", "", 30000, null, "8f6fbfd2-6073-44a3-9f03-cd194be45137");
                _breakfastInfo = new RepoItemInfo(this, "Breakfast", ".//input[@id=$addPlan]", "", 30000, null, "8bba2985-d01b-4326-af9c-52fae2eb9920");
                _contactInfo = new RepoItemInfo(this, "Contact", ".//select[#'contact']", "", 30000, null, "13704747-1136-4e60-ab8e-15b78736fd61");
                _submitbuttonInfo = new RepoItemInfo(this, "SubmitButton", ".//button[#'submit-button']", "", 30000, null, "d8ee3758-0f1f-4fa3-b483-ed041adc6800");
                _atag25Info = new RepoItemInfo(this, "ATag25", ".//div[#'ui-datepicker-div']/table//a[@innertext=$date]", "", 30000, null, "8d44a618-b9d4-4837-b167-871536dc73cc");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("35c6ba23-522c-4021-842d-4e8c89ceb27f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Date item.
            /// </summary>
            [RepositoryItem("82329a64-36c3-4883-9ae4-af756816b6f4")]
            public virtual Ranorex.InputTag Date
            {
                get
                {
                    return _dateInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Date item info.
            /// </summary>
            [RepositoryItemInfo("82329a64-36c3-4883-9ae4-af756816b6f4")]
            public virtual RepoItemInfo DateInfo
            {
                get
                {
                    return _dateInfo;
                }
            }

            /// <summary>
            /// The Term item.
            /// </summary>
            [RepositoryItem("fb587ea8-54f9-480d-9f2f-69789cb9f385")]
            public virtual Ranorex.InputTag Term
            {
                get
                {
                    return _termInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Term item info.
            /// </summary>
            [RepositoryItemInfo("fb587ea8-54f9-480d-9f2f-69789cb9f385")]
            public virtual RepoItemInfo TermInfo
            {
                get
                {
                    return _termInfo;
                }
            }

            /// <summary>
            /// The HeadCount item.
            /// </summary>
            [RepositoryItem("8f6fbfd2-6073-44a3-9f03-cd194be45137")]
            public virtual Ranorex.InputTag HeadCount
            {
                get
                {
                    return _headcountInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The HeadCount item info.
            /// </summary>
            [RepositoryItemInfo("8f6fbfd2-6073-44a3-9f03-cd194be45137")]
            public virtual RepoItemInfo HeadCountInfo
            {
                get
                {
                    return _headcountInfo;
                }
            }

            /// <summary>
            /// The Breakfast item.
            /// </summary>
            [RepositoryItem("8bba2985-d01b-4326-af9c-52fae2eb9920")]
            public virtual Ranorex.InputTag Breakfast
            {
                get
                {
                    return _breakfastInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Breakfast item info.
            /// </summary>
            [RepositoryItemInfo("8bba2985-d01b-4326-af9c-52fae2eb9920")]
            public virtual RepoItemInfo BreakfastInfo
            {
                get
                {
                    return _breakfastInfo;
                }
            }

            /// <summary>
            /// The Contact item.
            /// </summary>
            [RepositoryItem("13704747-1136-4e60-ab8e-15b78736fd61")]
            public virtual Ranorex.SelectTag Contact
            {
                get
                {
                    return _contactInfo.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The Contact item info.
            /// </summary>
            [RepositoryItemInfo("13704747-1136-4e60-ab8e-15b78736fd61")]
            public virtual RepoItemInfo ContactInfo
            {
                get
                {
                    return _contactInfo;
                }
            }

            /// <summary>
            /// The SubmitButton item.
            /// </summary>
            [RepositoryItem("d8ee3758-0f1f-4fa3-b483-ed041adc6800")]
            public virtual Ranorex.ButtonTag SubmitButton
            {
                get
                {
                    return _submitbuttonInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The SubmitButton item info.
            /// </summary>
            [RepositoryItemInfo("d8ee3758-0f1f-4fa3-b483-ed041adc6800")]
            public virtual RepoItemInfo SubmitButtonInfo
            {
                get
                {
                    return _submitbuttonInfo;
                }
            }

            /// <summary>
            /// The ATag25 item.
            /// </summary>
            [RepositoryItem("8d44a618-b9d4-4837-b167-871536dc73cc")]
            public virtual Ranorex.ATag ATag25
            {
                get
                {
                    return _atag25Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATag25 item info.
            /// </summary>
            [RepositoryItemInfo("8d44a618-b9d4-4837-b167-871536dc73cc")]
            public virtual RepoItemInfo ATag25Info
            {
                get
                {
                    return _atag25Info;
                }
            }
        }

        /// <summary>
        /// The 宿泊予約確認画面Folder folder.
        /// </summary>
        [RepositoryFolder("cec01dd7-f130-47b9-9b60-43c59dca8d63")]
        public partial class 宿泊予約確認画面Folder : RepoGenBaseFolder
        {
            RepoItemInfo _totalbillInfo;
            RepoItemInfo _この内容で予約するInfo;
            RepoItemInfo _buttontag閉じるInfo;

            /// <summary>
            /// Creates a new 宿泊予約確認画面  folder.
            /// </summary>
            public 宿泊予約確認画面Folder(RepoGenBaseFolder parentFolder) :
                    base("宿泊予約確認画面", "", parentFolder, 0, null, false, "cec01dd7-f130-47b9-9b60-43c59dca8d63", "")
            {
                _totalbillInfo = new RepoItemInfo(this, "TotalBill", ".//h3[#'total-bill']", "", 30000, null, "48277a68-11ad-43b1-bace-6776bc82902c");
                _この内容で予約するInfo = new RepoItemInfo(this, "この内容で予約する", ".//div[#'confirm']//button[@innertext='この内容で予約する']", "", 30000, null, "8a1d068a-aed7-4096-9436-458797818fdd");
                _buttontag閉じるInfo = new RepoItemInfo(this, "ButtonTag閉じる", ".//div[#'success-modal']/div/div/div[3]/button[@innertext='閉じる']", "", 30000, null, "81bf0725-d53b-45ce-8b06-51cae4db5c7a");
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("cec01dd7-f130-47b9-9b60-43c59dca8d63")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TotalBill item.
            /// </summary>
            [RepositoryItem("48277a68-11ad-43b1-bace-6776bc82902c")]
            public virtual Ranorex.H3Tag TotalBill
            {
                get
                {
                    return _totalbillInfo.CreateAdapter<Ranorex.H3Tag>(true);
                }
            }

            /// <summary>
            /// The TotalBill item info.
            /// </summary>
            [RepositoryItemInfo("48277a68-11ad-43b1-bace-6776bc82902c")]
            public virtual RepoItemInfo TotalBillInfo
            {
                get
                {
                    return _totalbillInfo;
                }
            }

            /// <summary>
            /// The この内容で予約する item.
            /// </summary>
            [RepositoryItem("8a1d068a-aed7-4096-9436-458797818fdd")]
            public virtual Ranorex.ButtonTag この内容で予約する
            {
                get
                {
                    return _この内容で予約するInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The この内容で予約する item info.
            /// </summary>
            [RepositoryItemInfo("8a1d068a-aed7-4096-9436-458797818fdd")]
            public virtual RepoItemInfo この内容で予約するInfo
            {
                get
                {
                    return _この内容で予約するInfo;
                }
            }

            /// <summary>
            /// The ButtonTag閉じる item.
            /// </summary>
            [RepositoryItem("81bf0725-d53b-45ce-8b06-51cae4db5c7a")]
            public virtual Ranorex.ButtonTag ButtonTag閉じる
            {
                get
                {
                    return _buttontag閉じるInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The ButtonTag閉じる item info.
            /// </summary>
            [RepositoryItemInfo("81bf0725-d53b-45ce-8b06-51cae4db5c7a")]
            public virtual RepoItemInfo ButtonTag閉じるInfo
            {
                get
                {
                    return _buttontag閉じるInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
