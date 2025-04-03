using DsUi;
using Godot;

namespace UI.Menu2;

public partial class Menu2Panel : Menu2
{
    //该函数会在创建Ui时调用
    public override void OnCreateUi()
    {
        //获取指定节点, 命名规则: L_ + 节点名称
        //这样就拿到了 Menu.VBoxContainer.Control.Start 路径下的节点, 注意, 此时的对象是包裹类型, 需要从 Instance 属性中获取原生节点对象
        var startButton = L_VBoxContainer.L_Control.L_VBoxContainer.L_Start;
        //绑定开始游戏的点击信号
        startButton.Instance.Pressed += OnStart;
        
        //但是上面这种写法过于繁琐, 特别是节点层数较高时获取节点就会比较麻烦
        //为了解决这个问题, DsUi 提供了第二种获取节点的方式, 获取场景中唯一名称的节点, 命名规则: S_ + 节点名称
        var settingButton = S_Setting;
        //绑定设置的点击信号
        settingButton.Instance.Pressed += OnSetting;
        
        //进一步缩写, 绑定退出游戏信号
        S_Exit.Instance.Pressed += OnExit;
        
        //但是注意如果场景中有两个相同名称的节点, 那么就不能够通过 S_ + 节点名称 的方式获取节点
        //例如当前Ui场景中有两个名叫 VBoxContainer 的节点
        //var node = S_VBoxContainer; //编译错误: 找不到 S_VBoxContainer
    }

    //该函数会在销毁Ui时调用
    public override void OnDestroyUi()
    {
        
    }

    //点击开始游戏
    private void OnStart()
    {
        //打开下一级游戏中页面
        OpenNextUi(UiManager.UiName.GameUi);
    }

    //点击设置
    private void OnSetting()
    {
        //打开下一级设置页面
        OpenNextUi(UiManager.UiName.Setting);
    }
    
    //退出游戏
    private void OnExit()
    {
        GetTree().Quit();
    }
}
