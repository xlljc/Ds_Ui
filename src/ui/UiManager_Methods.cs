namespace DsUi;

// 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string CommonWindow = "CommonWindow";
        public const string GameUi = "GameUi";
        public const string Menu = "Menu";
        public const string Package = "Package";
        public const string Setting = "Setting";
        public const string Tips = "Tips";
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
        var uiInstance = GetUiInstance<UI.CommonWindow.CommonWindowPanel>(UiName.CommonWindow);
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
        var uiInstance = GetUiInstance<UI.GameUi.GameUiPanel>(UiName.GameUi);
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
        var uiInstance = GetUiInstance<UI.Menu.MenuPanel>(UiName.Menu);
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
        var uiInstance = GetUiInstance<UI.Package.PackagePanel>(UiName.Package);
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
        var uiInstance = GetUiInstance<UI.Setting.SettingPanel>(UiName.Setting);
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
        var uiInstance = GetUiInstance<UI.Tips.TipsPanel>(UiName.Tips);
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

}
