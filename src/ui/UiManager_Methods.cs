namespace DsUi;
//该类为自动生成的, 请不要手动编辑, 以免造成代码丢失
public static partial class UiManager
{

    public static class UiName
    {
        public const string Menu = "Menu";
        public const string Setting = "Setting";
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

}
