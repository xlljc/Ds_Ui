using Godot;
using DsUi;

namespace UI.Setting;

public partial class SettingPanel : Setting
{

    public override void OnCreateUi()
    {
        //有上一级Ui
        if (PrevUi != null)
        {
            S_Back.Instance.Pressed += OnBack;
        }
        else //隐藏返回按钮
        {
            S_Back.Instance.Visible = false;
        }
        S_Apply.Instance.Pressed += OnApply;
    }

    public override void OnDestroyUi()
    {
        
    }

    //返回上一级Ui
    private void OnBack()
    {
        //打开上一级Ui, 关闭并销毁当前Ui
        OpenPrevUi();
    }

    //应用按钮点击
    private void OnApply()
    {
        //设置1
        var v1 = S_SettingValue1.Instance.Value;
        //设置2
        var v2 = S_SettingValue2.Instance.Selected;
        //设置3
        var v3 = S_SettingValue3.Instance.Value;

        var str = $"设置1: {v1}\n设置2: {v2}\n设置3: {v3}";
        //打开提示
        UiManager.Open_Tips().InitData("提示", str, () =>
        {
            GD.Print("应用Tips回调");
        });
    }

}
