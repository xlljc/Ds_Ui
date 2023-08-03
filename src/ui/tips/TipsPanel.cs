using System;
using Godot;

namespace UI.Tips;

public partial class TipsPanel : Tips
{
    //关闭回调
    private Action _onClose;

    public override void OnCreateUi()
    {
        //设置关闭回调
        S_AcceptDialog.Instance.Confirmed += () =>
        {
            //关闭Tips时销毁Ui
            Destroy();

            if (_onClose != null)
            {
                _onClose();
            }
        };
        S_AcceptDialog.Instance.Canceled += () =>
        {
            //关闭Tips时销毁Ui
            Destroy();
            
            if (_onClose != null)
            {
                _onClose();
            }
        };
    }

    public override void OnDestroyUi()
    {
        
    }

    /// <summary>
    /// 初始化Tips显示的数据
    /// </summary>
    /// <param name="title">标题</param>
    /// <param name="message">显示内容</param>
    /// <param name="onClose">关闭时回调</param>
    public void InitData(string title, string message, Action onClose = null)
    {
        //设置标题
        S_AcceptDialog.Instance.Title = title;
        //设置内容
        S_AcceptDialog.Instance.DialogText = message;
        //关闭回调
        _onClose = onClose;
        //弹出窗口
        S_AcceptDialog.Instance.Popup();
    }

}
