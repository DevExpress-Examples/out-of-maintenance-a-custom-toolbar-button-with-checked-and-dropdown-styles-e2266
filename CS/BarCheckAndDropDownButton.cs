using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;

namespace CustomCheckAndDropDownButton {
    class BarCheckAndDropDownButton : BarButtonItem {
        public BarCheckAndDropDownButton() {
            ActAsCheck = true;
            ButtonStyle = BarButtonStyle.DropDown;
        }

        private bool actAsCheck;
        public bool ActAsCheck {
            get { return actAsCheck; }
            set {
                actAsCheck = value;
            }
        }

        public override bool CanDown {
            get {
                return base.CanDown || (ActAsCheck && ButtonStyle == BarButtonStyle.DropDown);
            }
        }
        protected override void OnClick(BarItemLink link) {
            if(ActAsCheck && ButtonStyle != BarButtonStyle.Check)
                Toggle();
            base.OnClick(link);
        }
    }

    public class BarCheckAndDropDownButtonLinkViewInfo : BarButtonLinkViewInfo {
        public BarCheckAndDropDownButtonLinkViewInfo(BarDrawParameters parameters, BarItemLink link) : base(parameters, link) { }
        protected override BarLinkState CalcLinkState() {
            BarLinkState state = base.CalcLinkState();
            //if(Link.Item.Down) state |= BarLinkState.Checked;
            return state;
        }
    }

    public class BarCheckAndDropDownButtonLinkPainter : BarButtonOffice2003LinkPainter {
        public BarCheckAndDropDownButtonLinkPainter(BarManagerPaintStyle style) : base(style) { }
        protected override void DrawLinkAdornments(BarLinkPaintArgs e, BarLinkState drawState) {
            if(e.LinkInfo.IsDrawPart(BarLinkParts.OpenArrow)) {
                //if((drawState & BarLinkState.Pressed) > 0) 
                //    drawState = (drawState | BarLinkState.Highlighted) & ~BarLinkState.Pressed;
                drawState &= ~BarLinkState.Checked;
                //Console.WriteLine(drawState);
            }
            
            base.DrawLinkAdornments(e, drawState);
        }
    }

    class ItemRegistrationHelper {
        public static void RegisterCustomItems() {
        	BarManagerPaintStyleCollection styles = BarAndDockingController.Default.PaintStyles;
			BarManagerPaintStyle style = styles["Skin"];
            style.ItemInfoCollection.Add(new BarItemInfo("BarCheckAndDropDownButton", 
                "Check && DropDown Button", 0, typeof(BarCheckAndDropDownButton), typeof(BarButtonItemLink),
                typeof(BarCheckAndDropDownButtonLinkViewInfo),
                new BarCheckAndDropDownButtonLinkPainter(style), true, true));
        }
    }
}
