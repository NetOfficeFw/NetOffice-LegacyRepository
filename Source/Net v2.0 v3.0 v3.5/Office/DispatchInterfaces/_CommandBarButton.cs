//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface _CommandBarButton SupportByLibrary OF09 OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
	public class _CommandBarButton : CommandBarControl
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBarButton(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBarButton(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBarButton(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CommandBarButton()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public COMObject accParent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accParent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Int32 accChildCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accChildCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public COMObject get_accChild(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accChild", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string get_accName(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void set_accName(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accName", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string accName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string get_accValue(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void set_accValue(object varChild, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.PropertySet(this, "accValue", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string accValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "accValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string get_accDescription(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string accDescription
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDescription", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object get_accRole(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accRole
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accRole", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object get_accState(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accState", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string get_accHelp(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string accHelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accHelp", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="pszHelpFile">ref string pszHelpFile</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Int32 get_accHelpTopic(ref string pszHelpFile, object varChild)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile, varChild);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			pszHelpFile = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="pszHelpFile">ref string pszHelpFile</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Int32 get_accHelpTopic(ref string pszHelpFile)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pszHelpFile);
			object returnItem = Invoker.PropertyGet(this, "accHelpTopic", paramsArray);
			pszHelpFile = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string get_accKeyboardShortcut(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string accKeyboardShortcut
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accKeyboardShortcut", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accFocus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accFocus", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accSelection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accSelection", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string get_accDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string accDefaultAction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "accDefaultAction", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public bool BuiltInFace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuiltInFace", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BuiltInFace", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Int32 FaceId
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FaceId", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FaceId", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public string ShortcutText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShortcutText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShortcutText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoButtonState State
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "State", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoButtonState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "State", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoButtonStyle Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoButtonStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoCommandBarButtonHyperlinkType HyperlinkType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HyperlinkType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoCommandBarButtonHyperlinkType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HyperlinkType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public stdole.Picture Picture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Picture", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Picture", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public stdole.Picture Mask
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Mask", paramsArray);
				stdole.Picture newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Mask", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF14 
		/// </summary>
		[SupportByLibrary("OF14")]
		public object InstanceIdPtr
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InstanceIdPtr", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void accSelect(Int32 flagsSelect, object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect, varChild);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="flagsSelect">Int32 flagsSelect</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void accSelect(Int32 flagsSelect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(flagsSelect);
			Invoker.Method(this, "accSelect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="pxLeft">ref Int32 pxLeft</param>
		/// <param name="pyTop">ref Int32 pyTop</param>
		/// <param name="pcxWidth">ref Int32 pcxWidth</param>
		/// <param name="pcyHeight">ref Int32 pcyHeight</param>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void accLocation(ref Int32 pxLeft, ref Int32 pyTop, ref Int32 pcxWidth, ref Int32 pcyHeight, object varChild)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight, varChild);
			Invoker.Method(this, "accLocation", paramsArray, modifiers);
			pxLeft = (Int32)paramsArray[0];
			pyTop = (Int32)paramsArray[1];
			pcxWidth = (Int32)paramsArray[2];
			pcyHeight = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="pxLeft">ref Int32 pxLeft</param>
		/// <param name="pyTop">ref Int32 pyTop</param>
		/// <param name="pcxWidth">ref Int32 pcxWidth</param>
		/// <param name="pcyHeight">ref Int32 pcyHeight</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void accLocation(ref Int32 pxLeft, ref Int32 pyTop, ref Int32 pcxWidth, ref Int32 pcyHeight)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(pxLeft, pyTop, pcxWidth, pcyHeight);
			Invoker.Method(this, "accLocation", paramsArray, modifiers);
			pxLeft = (Int32)paramsArray[0];
			pyTop = (Int32)paramsArray[1];
			pcxWidth = (Int32)paramsArray[2];
			pcyHeight = (Int32)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		/// <param name="varStart">optional object varStart</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accNavigate(Int32 navDir, object varStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir, varStart);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="navDir">Int32 navDir</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accNavigate(Int32 navDir)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(navDir);
			object returnItem = Invoker.MethodReturn(this, "accNavigate", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="xLeft">Int32 xLeft</param>
		/// <param name="yTop">Int32 yTop</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public object accHitTest(Int32 xLeft, Int32 yTop)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xLeft, yTop);
			object returnItem = Invoker.MethodReturn(this, "accHitTest", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="varChild">optional object varChild</param>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void accDoDefaultAction(object varChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varChild);
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void accDoDefaultAction()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "accDoDefaultAction", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void CopyFace()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CopyFace", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public void PasteFace()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PasteFace", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}