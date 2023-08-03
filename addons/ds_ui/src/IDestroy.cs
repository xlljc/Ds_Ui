namespace DsUi
{
    /// <summary>
    /// 销毁接口
    /// </summary>
    public interface IDestroy
    {
        /// <summary>
        /// 返回物体是否已经被销毁
        /// </summary>
        bool IsDestroyed { get; }

        /// <summary>
        /// 销毁物体
        /// </summary>
        void Destroy();
    }
}