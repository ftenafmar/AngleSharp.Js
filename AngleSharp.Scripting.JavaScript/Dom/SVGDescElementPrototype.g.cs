namespace AngleSharp.Scripting.JavaScript
{
    using AngleSharp.Dom.Svg;
    using Jint;
    using Jint.Native;
    using Jint.Native.Object;
    using Jint.Runtime;
    using Jint.Runtime.Descriptors;
    using Jint.Runtime.Interop;
    using System;

    sealed partial class SVGDescElementPrototype : SVGDescElementInstance
    {
        public SVGDescElementPrototype(Engine engine)
            : base(engine)
        {
            FastAddProperty("toString", Engine.AsValue(ToString), true, true, true);
        }

        public static SVGDescElementPrototype CreatePrototypeObject(EngineInstance engine, SVGDescElementConstructor constructor)
        {
            var obj = new SVGDescElementPrototype(engine.Jint)
            {
                Prototype = engine.Constructors.SVGElement.PrototypeObject,
                Extensible = true,
            };
            obj.FastAddProperty("constructor", constructor, true, false, true);
            return obj;
        }

        JsValue ToString(JsValue thisObj, JsValue[] arguments)
        {
            return "[object SVGDescElement]";
        }

        void Fail(JsValue obsolete)
        {
            throw new JavaScriptException(Engine.TypeError);
        }
    }
}