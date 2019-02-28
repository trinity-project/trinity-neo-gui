using Neo.Core;
using Neo.Implementations.Wallets.EntityFramework;
using Neo.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Neo.GUIPlugin
{
    public class PluginTool
    {
        public Dictionary<string, IPlugin> plugins = new Dictionary<string, IPlugin>();
        public List<string> errors = new List<string>();
        public List<string> failPlugin = new List<string>();

        public void LoadDlls(string path = "plugins", string searchPattern = "*.dll")
        {
            //loadplugin
            var files = System.IO.Directory.GetFiles(path, searchPattern);
            foreach (var file in files)
            {
                try
                {
                    var dll = System.Reflection.Assembly.LoadFile(System.IO.Path.GetFullPath(file));
                    foreach (var t in dll.ExportedTypes)
                    {
                        var b = t.GetInterfaces().Contains(typeof(IPlugin));
                        if (b)
                        {
                            var plugin = t.Assembly.CreateInstance(t.FullName) as IPlugin;
                            var name = plugin.Name;
                            plugins.Add(name, plugin);
                        }
                    }
                }
                catch (Exception err)
                {
                    string errstr = "error load:" + file + "  err:" + err.Message;
                    errors.Add(errstr);
                    Console.WriteLine(errstr);
                }

            }
        }

        public void InitMenu(System.Windows.Forms.MenuStrip menuStrip)
        {
            System.Windows.Forms.ToolStripMenuItem item = new System.Windows.Forms.ToolStripMenuItem();
            if (plugins.Count == 0){return;}
            foreach (var plugin in plugins)
            {
                try
                {
                    System.Windows.Forms.ToolStripMenuItem pitem = new System.Windows.Forms.ToolStripMenuItem();
                    pitem.Text = plugin.Key;
                    string menuPosition = plugin.Value.GetMenuPosition();
                    int index = plugin.Value.GetMenuIndex();
                    bool f = false;
                    foreach (ToolStripMenuItem rootmenu in menuStrip.Items)
                    {
                        if (rootmenu.Name == menuPosition)
                        {
                            if (index < 0) { rootmenu.DropDownItems.Add(pitem); }
                            else { rootmenu.DropDownItems.Insert(index, pitem); }
                            f = true;
                        }
                    }
                    if (!f)
                    {
                        ToolStripMenuItem newMenu = new ToolStripMenuItem(menuPosition);
                        newMenu.Name = menuPosition;
                        menuStrip.Items.Add(newMenu);
                        if (index < 0) { newMenu.DropDownItems.Add(pitem); }
                        else { newMenu.DropDownItems.Insert(index, pitem); }
                    }

                    var _plugin = plugin.Value;
                    pitem.Click += (s, e) =>
                    {
                        try
                        {
                            _plugin.MenuClick();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("error:" + err.Message);
                        }
                    };

                    foreach (var childrenMenus in plugin.Value.GetMenus())
                    {
                        System.Windows.Forms.ToolStripMenuItem childrenItem = new System.Windows.Forms.ToolStripMenuItem();
                        childrenItem.Text = childrenMenus;

                        pitem.DropDownItems.Add(childrenItem);
                        var __plugin = plugin.Value;
                        var __menu = childrenMenus;
                        childrenItem.Click += (s, e) =>
                          {
                              try
                              {
                                  __plugin.ChildrenMenuClick(__menu);
                              }
                              catch (Exception err)
                              {
                                  MessageBox.Show("error:" + err.Message);
                              }
                          };
                    }
                }
                finally { }
            }
        }
    }

    public interface IPlugin
    {
        string Name{ get; }
        string GetMenuPosition();
        int GetMenuIndex();
        string[] GetMenus();
        void MenuClick();
        void ChildrenMenuClick(string menu);
    }
}
