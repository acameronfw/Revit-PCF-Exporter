using Autodesk.Revit.DB;

using Shared;
using PCF_Functions;
using plst = PCF_Functions.Parameters;

using System;
using System.Collections.Generic;
using System.Text;

namespace PCF_Model
{
    internal class PCF_REDUCER_CONCENTRIC : PCF_EP1_EP2
    {
        public PCF_REDUCER_CONCENTRIC(Element element) : base(element) { }
        protected override StringBuilder WriteSpecificData()
        {
            StringBuilder sb = new StringBuilder();

            //Plant3dISO Writer
            sb.Append(Composer.Plant3DIsoWriter(Element, Element.Document));

            sb.Append(base.WriteSpecificData());
/*
            //Temporary hack
            sb.AppendLine("    FLAT-DIRECTION DOWN");*/
            return sb;
        }
    }
}
