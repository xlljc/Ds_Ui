# DsUi

---
`DsUi`是一款用于`Godot Mono`快速开发Ui的插件, 核心功能如下:
* 提供Ui管理器`UiManager.cs`, 负责管理Ui生命周期
* 根据Ui场景自动生成Ui节点属性代码, 支持生成唯一名称节点属性
* 根据Ui场景文件自动生成打开Ui/关闭Ui/获取实例的函数
* 支持Ui嵌套, 提供动态打嵌套Ui函数和场景内静态嵌套Ui功能
* 提供Ui网格布局组件(`UiGrid.cs`), 更方便管理单个Cell
* 支持类似Unity中的协程函数
---

### 使用该插件的好处是什么?
众所周知, 使用C#开发Godot游戏, 无法像GDS那样有原生特性支持(`$+节点名称`), C#获取节点必须使用`GetNode()`函数, 或者`[Export()]`节点属性, 再到编辑器中拖拽赋值. 这样编写很麻烦, 如果使用`GetNode()`来获取节点, 场景中该节点移动位置或者更改名称, 那么`GetNode()`就无法获取到该节点, 这个时候就需要手动更改传入的节点路径, 当项目小还比较好改, 但是大项目重构节点, 那么代码需要更改的地方就非常多, 而且无法快速定位到哪些`GetNode()`函数需要更改.  
在开发Ui时, 因为需要频繁获取节点, 上面的问题就会被放大  
DsUi插件就是为了解决这个问题, **在编辑场景完成后动态生成节点代码**, 这样代码中如果有引用更改, 就可以根据报错立刻定位到需要修改的位置 (不怕编译时报错, 就怕运行时才报错)
