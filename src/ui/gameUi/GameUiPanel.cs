using DsUi;
using UI.Package;
using UI.Setting;

namespace UI.GameUi;

public partial class GameUiPanel : GameUi
{

    private int _coin = 0;
    
    public override void OnCreateUi()
    {
        //返回上一级
        S_Back.Instance.Pressed += OnBack;
        //打开背包
        S_Package.Instance.Pressed += OnPackage;
        //打开设置
        S_Setting.Instance.Pressed += OnSetting;
    }

    public override void OnDestroyUi()
    {
        
    }

    /// <summary>
    /// 增加金币函数
    /// </summary>
    public void AddCoin(int count)
    {
        _coin += count;
        S_Coin.Instance.Text = "金币数量: " + _coin;
    }

    //返回上一级Ui
    private void OnBack()
    {
        //打开上一级Ui, 关闭并销毁当前Ui
        OpenPrevUi();
    }

    //打开背包
    private void OnPackage()
    {
        //打开通用窗体
        var window = UiManager.Open_CommonWindow();
        //调用通用窗体中的函数打开背包子页面
        window.OpenBody<PackagePanel>("背包", UiManager.UiName.Package);
    }

    //打开设置
    private void OnSetting()
    {
        //打开通用窗体
        var window = UiManager.Open_CommonWindow();
        //调用通用窗体中的函数打开背包子页面
        window.OpenBody<SettingPanel>("背包", UiManager.UiName.Setting);
    }
}
