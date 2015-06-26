/*
' Copyright (c) 2015  Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;

namespace Christoc.Modules.DNNDAL2
{
    public class DNNDAL2ModuleBase : PortalModuleBase
    {
        public int ItemId
        {
            get
            {
                var qs = Request.QueryString["tid"];
                if (qs != null)
                    return Convert.ToInt32(qs);
                return -1;
            }

        }

        protected void GetModule()
        {
            try
            {

                string controlKey;
                if (Request.Params["cid"] == null)
                {
                    controlKey = "List";
                }
                else
                    controlKey = Request.Params["cid"];

                string mPath = getModulePath(ModuleId, TabId, controlKey);
                var objModule = (PortalModuleBase)this.LoadControl(mPath);

                objModule.ModuleConfiguration = this.ModuleConfiguration;

                objModule.LocalResourceFile = this.LocalResourceFile.Replace("Dispatch", controlKey);
                this.Controls.Add(objModule);
            }

            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }


        }







        private string getModulePath(int moduleid, int tabid, string controlKey)
        {
            string path = String.Empty;
            try
            {
                ModuleController mc = new ModuleController();
                ModuleControlController mcc = new ModuleControlController();

                ModuleInfo mi = mc.GetModule(moduleid, tabid);
                if (mi != null)
                {
                    var mControl = ModuleControlController.GetModuleControlByControlKey(controlKey, mi.ModuleDefID);
                    if (mControl != null)
                        path = "~/" + mControl.ControlSrc;
                }
            }
            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }
            return path;

        }




    }


}