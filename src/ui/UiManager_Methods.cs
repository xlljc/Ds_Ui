namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string Aa_Baba_Aaa = "aa/Baba/Aaa";
        public const string Aa_BB_Cc = "aa/BB/Cc";
        public const string CommonWindow = "CommonWindow";
        public const string GameUi = "GameUi";
        public const string Menu = "Menu";
        public const string Package = "Package";
        public const string Setting = "Setting";
        public const string Tips = "Tips";
    }

    /// <summary>
    /// 打开 aa/Baba/Aaa, 并返回UI实例
    /// </summary>
    public static UI.aa.Baba.Aaa.AaaPanel Open_Aa_Baba_Aaa()
    {
        return OpenUi<UI.aa.Baba.Aaa.AaaPanel>(UiName.Aa_Baba_Aaa);
    }

    /// <summary>
    /// 销毁 aa/Baba/Aaa 的所有实例
    /// </summary>
    public static void Destroy_Aa_Baba_Aaa()
    {
        var uiInstance = GetUiInstance<UI.aa.Baba.Aaa.AaaPanel>(nameof(UI.aa.Baba.Aaa.Aaa));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 aa/BB/Cc, 并返回UI实例
    /// </summary>
    public static UI.aa.BB.Cc.CcPanel Open_Aa_BB_Cc()
    {
        return OpenUi<UI.aa.BB.Cc.CcPanel>(UiName.Aa_BB_Cc);
    }

    /// <summary>
    /// 销毁 aa/BB/Cc 的所有实例
    /// </summary>
    public static void Destroy_Aa_BB_Cc()
    {
        var uiInstance = GetUiInstance<UI.aa.BB.Cc.CcPanel>(nameof(UI.aa.BB.Cc.Cc));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 CommonWindow, 并返回UI实例
    /// </summary>
    public static UI.CommonWindow.CommonWindowPanel Open_CommonWindow()
    {
        return OpenUi<UI.CommonWindow.CommonWindowPanel>(UiName.CommonWindow);
    }

    /// <summary>
    /// 销毁 CommonWindow 的所有实例
    /// </summary>
    public static void Destroy_CommonWindow()
    {
        var uiInstance = GetUiInstance<UI.CommonWindow.CommonWindowPanel>(nameof(UI.CommonWindow.CommonWindow));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 GameUi, 并返回UI实例
    /// </summary>
    public static UI.GameUi.GameUiPanel Open_GameUi()
    {
        return OpenUi<UI.GameUi.GameUiPanel>(UiName.GameUi);
    }

    /// <summary>
    /// 销毁 GameUi 的所有实例
    /// </summary>
    public static void Destroy_GameUi()
    {
        var uiInstance = GetUiInstance<UI.GameUi.GameUiPanel>(nameof(UI.GameUi.GameUi));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 Menu, 并返回UI实例
    /// </summary>
    public static UI.Menu.MenuPanel Open_Menu()
    {
        return OpenUi<UI.Menu.MenuPanel>(UiName.Menu);
    }

    /// <summary>
    /// 销毁 Menu 的所有实例
    /// </summary>
    public static void Destroy_Menu()
    {
        var uiInstance = GetUiInstance<UI.Menu.MenuPanel>(nameof(UI.Menu.Menu));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 Package, 并返回UI实例
    /// </summary>
    public static UI.Package.PackagePanel Open_Package()
    {
        return OpenUi<UI.Package.PackagePanel>(UiName.Package);
    }

    /// <summary>
    /// 销毁 Package 的所有实例
    /// </summary>
    public static void Destroy_Package()
    {
        var uiInstance = GetUiInstance<UI.Package.PackagePanel>(nameof(UI.Package.Package));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 Setting, 并返回UI实例
    /// </summary>
    public static UI.Setting.SettingPanel Open_Setting()
    {
        return OpenUi<UI.Setting.SettingPanel>(UiName.Setting);
    }

    /// <summary>
    /// 销毁 Setting 的所有实例
    /// </summary>
    public static void Destroy_Setting()
    {
        var uiInstance = GetUiInstance<UI.Setting.SettingPanel>(nameof(UI.Setting.Setting));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 打开 Tips, 并返回UI实例
    /// </summary>
    public static UI.Tips.TipsPanel Open_Tips()
    {
        return OpenUi<UI.Tips.TipsPanel>(UiName.Tips);
    }

    /// <summary>
    /// 销毁 Tips 的所有实例
    /// </summary>
    public static void Destroy_Tips()
    {
        var uiInstance = GetUiInstance<UI.Tips.TipsPanel>(nameof(UI.Tips.Tips));
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

}
