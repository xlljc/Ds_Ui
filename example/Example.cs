using Godot;
using DsUi;

public partial class Example : Node2D
{
    public override void _Ready()
    {
        //初始化Ui管理器
        UiManager.Init(this);
        
        //打开Ui
        UiManager.Open_Menu();
    }
}
