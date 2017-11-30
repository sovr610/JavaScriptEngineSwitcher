//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace JavaScriptEngineSwitcher.V8.Resources
{
	using System;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	internal class Strings
	{
		private static Lazy<ResourceManager> _resourceManager =
			new Lazy<ResourceManager>(() => new ResourceManager(
				"JavaScriptEngineSwitcher.V8.Resources.Strings",
#if NET40
				typeof(Strings).Assembly
#else
				typeof(Strings).GetTypeInfo().Assembly
#endif
			));

		private static CultureInfo _resourceCulture;

		/// <summary>
		/// Returns a cached ResourceManager instance used by this class
		/// </summary>
		internal static ResourceManager ResourceManager
		{
			get
			{
				return _resourceManager.Value;
			}
		}

		/// <summary>
		/// Overrides a current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class
		/// </summary>
		internal static CultureInfo Culture
		{
			get
			{
				return _resourceCulture;
			}
			set
			{
				_resourceCulture = value;
			}
		}

		/// <summary>
		/// Looks up a localized string similar to "Failed to load the ClearScript `undefined` value."
		/// </summary>
		internal static string Engines_ClearScriptUndefinedValueNotLoaded
		{
			get { return GetString("Engines_ClearScriptUndefinedValueNotLoaded"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Failed to load the ClearScriptV8 assembly, because the '{0}' file does not exist. It is possible,..."
		/// </summary>
		internal static string Engines_ClearScriptV8AssemblyFileNotFound
		{
			get { return GetString("Engines_ClearScriptV8AssemblyFileNotFound"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Failed to load information about the `{1}` method of type `{0}`."
		/// </summary>
		internal static string Runtime_MethodInfoNotLoaded
		{
			get { return GetString("Runtime_MethodInfoNotLoaded"); }
		}

		private static string GetString(string name)
		{
			string value = ResourceManager.GetString(name, _resourceCulture);

			return value;
		}
	}
}