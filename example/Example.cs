using Godot;
using DsUi;

public partial class Example : Node2D
{
    public override void _Ready()
    {
        //打开Ui
        //UiManager.Open_Menu();
        UiManager.Open_Aa_Baba_Aaa();
        
        var t = CreateTween();
        t.TweenInterval(3d);
        t.TweenCallback(Callable.From(() =>
        {
            UiManager.Destroy_Aa_Baba_Aaa();
        }));
    }
}
