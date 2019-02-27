using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neo.GUIPlugin;

namespace plugin_trinity
{
    public class baseTemplate : IPlugin
    {
        /// <summary>
        /// 设置插件名称
        /// </summary>
        /// <returns>插件名称</returns>
        public string Name => "New Plugin";

        /// <summary>
        /// 设置菜单路径
        /// 如果想添加到默认的菜单栏下，则将该ToolStripMenuItem的Name作为返回值，如"钱包WToolStripMenuItem"
        /// </summary>
        /// <returns>菜单路径</returns>
        public string GetMenuPosition()
        {
            return "Plugin";
        }

        /// <summary>
        /// 设置插件在当前菜单的显示位置
        /// 0为显示在第一个，1为显示在第2个，小于0为显示在最后一个（包含分割线）
        /// </summary>
        /// <returns>插件显示在菜单的位置</returns>
        public int GetMenuIndex()
        {
            return -1;
        }

        /// <summary>
        /// 设置菜单子集选项
        /// 如不含菜单子集，则为空
        /// </summary>
        /// <returns>菜单子集集合</returns>
        public string[] GetMenus()
        {
            return new string[] { "test1", "test2" };
        }

        /// <summary>
        /// 插件菜单按钮点击事件
        /// 如不含点击事件，则为空
        /// </summary>
        public void MenuClick()
        {
            var Form01 = new Form01();
            Form01.ShowDialog();
        }

        /// <summary>
        /// 插件子集按钮点击事件
        /// 如不含点击事件，则为空
        /// </summary>
        public void ChildrenMenuClick(string menu)
        {
            if (menu == "test1")
            {
                var Form01 = new Form01();
                Form01.ShowDialog();
            }
        }
    }
}
