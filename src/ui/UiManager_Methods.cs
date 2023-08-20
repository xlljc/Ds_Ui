namespace DsUi;

/*
 * 该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
 */
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
    /// 创建 CommonWindow, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static UI.CommonWindow.CommonWindowPanel Create_CommonWindow()
    {
        return CreateUi<UI.CommonWindow.CommonWindowPanel>(UiName.CommonWindow);
    }

    /// <summary>
    /// 打开 CommonWindow, 并返回UI实例
    /// </summary>
    public static UI.CommonWindow.CommonWindowPanel Open_CommonWindow()
    {
        return OpenUi<UI.CommonWindow.CommonWindowPanel>(UiName.CommonWindow);
    }

    /// <summary>
    /// 隐藏 CommonWindow 的所有实例
    /// </summary>
    public static void Hide_CommonWindow()
    {
        var uiInstance = Get_CommonWindow_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 CommonWindow 的所有实例
    /// </summary>
    public static void Destroy_CommonWindow()
    {
        var uiInstance = Get_CommonWindow_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 CommonWindow 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static UI.CommonWindow.CommonWindowPanel[] Get_CommonWindow_Instance()
    {
        return GetUiInstance<UI.CommonWindow.CommonWindowPanel>(nameof(UI.CommonWindow.CommonWindow));
    }

    /// <summary>
    /// 创建 GameUi, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static UI.GameUi.GameUiPanel Create_GameUi()
    {
        return CreateUi<UI.GameUi.GameUiPanel>(UiName.GameUi);
    }

    /// <summary>
    /// 打开 GameUi, 并返回UI实例
    /// </summary>
    public static UI.GameUi.GameUiPanel Open_GameUi()
    {
        return OpenUi<UI.GameUi.GameUiPanel>(UiName.GameUi);
    }

    /// <summary>
    /// 隐藏 GameUi 的所有实例
    /// </summary>
    public static void Hide_GameUi()
    {
        var uiInstance = Get_GameUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 GameUi 的所有实例
    /// </summary>
    public static void Destroy_GameUi()
    {
        var uiInstance = Get_GameUi_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 GameUi 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static UI.GameUi.GameUiPanel[] Get_GameUi_Instance()
    {
        return GetUiInstance<UI.GameUi.GameUiPanel>(nameof(UI.GameUi.GameUi));
    }

    /// <summary>
    /// 创建 Menu, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static UI.Menu.MenuPanel Create_Menu()
    {
        return CreateUi<UI.Menu.MenuPanel>(UiName.Menu);
    }

    /// <summary>
    /// 打开 Menu, 并返回UI实例
    /// </summary>
    public static UI.Menu.MenuPanel Open_Menu()
    {
        return OpenUi<UI.Menu.MenuPanel>(UiName.Menu);
    }

    /// <summary>
    /// 隐藏 Menu 的所有实例
    /// </summary>
    public static void Hide_Menu()
    {
        var uiInstance = Get_Menu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Menu 的所有实例
    /// </summary>
    public static void Destroy_Menu()
    {
        var uiInstance = Get_Menu_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Menu 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static UI.Menu.MenuPanel[] Get_Menu_Instance()
    {
        return GetUiInstance<UI.Menu.MenuPanel>(nameof(UI.Menu.Menu));
    }

    /// <summary>
    /// 创建 Package, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static UI.Package.PackagePanel Create_Package()
    {
        return CreateUi<UI.Package.PackagePanel>(UiName.Package);
    }

    /// <summary>
    /// 打开 Package, 并返回UI实例
    /// </summary>
    public static UI.Package.PackagePanel Open_Package()
    {
        return OpenUi<UI.Package.PackagePanel>(UiName.Package);
    }

    /// <summary>
    /// 隐藏 Package 的所有实例
    /// </summary>
    public static void Hide_Package()
    {
        var uiInstance = Get_Package_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Package 的所有实例
    /// </summary>
    public static void Destroy_Package()
    {
        var uiInstance = Get_Package_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Package 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static UI.Package.PackagePanel[] Get_Package_Instance()
    {
        return GetUiInstance<UI.Package.PackagePanel>(nameof(UI.Package.Package));
    }

    /// <summary>
    /// 创建 Setting, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static UI.Setting.SettingPanel Create_Setting()
    {
        return CreateUi<UI.Setting.SettingPanel>(UiName.Setting);
    }

    /// <summary>
    /// 打开 Setting, 并返回UI实例
    /// </summary>
    public static UI.Setting.SettingPanel Open_Setting()
    {
        return OpenUi<UI.Setting.SettingPanel>(UiName.Setting);
    }

    /// <summary>
    /// 隐藏 Setting 的所有实例
    /// </summary>
    public static void Hide_Setting()
    {
        var uiInstance = Get_Setting_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Setting 的所有实例
    /// </summary>
    public static void Destroy_Setting()
    {
        var uiInstance = Get_Setting_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Setting 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static UI.Setting.SettingPanel[] Get_Setting_Instance()
    {
        return GetUiInstance<UI.Setting.SettingPanel>(nameof(UI.Setting.Setting));
    }

    /// <summary>
    /// 创建 Tips, 并返回UI实例, 该函数不会打开 Ui
    /// </summary>
    public static UI.Tips.TipsPanel Create_Tips()
    {
        return CreateUi<UI.Tips.TipsPanel>(UiName.Tips);
    }

    /// <summary>
    /// 打开 Tips, 并返回UI实例
    /// </summary>
    public static UI.Tips.TipsPanel Open_Tips()
    {
        return OpenUi<UI.Tips.TipsPanel>(UiName.Tips);
    }

    /// <summary>
    /// 隐藏 Tips 的所有实例
    /// </summary>
    public static void Hide_Tips()
    {
        var uiInstance = Get_Tips_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.HideUi();
        }
    }

    /// <summary>
    /// 销毁 Tips 的所有实例
    /// </summary>
    public static void Destroy_Tips()
    {
        var uiInstance = Get_Tips_Instance();
        foreach (var uiPanel in uiInstance)
        {
            uiPanel.Destroy();
        }
    }

    /// <summary>
    /// 获取所有 Tips 的实例, 如果没有实例, 则返回一个空数组
    /// </summary>
    public static UI.Tips.TipsPanel[] Get_Tips_Instance()
    {
        return GetUiInstance<UI.Tips.TipsPanel>(nameof(UI.Tips.Tips));
    }

}
