//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// About - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutHeadline")]
		public virtual string AboutHeadline => this.Value<string>(_publishedValueFallback, "aboutHeadline");

		///<summary>
		/// About - Quote
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutQuote")]
		public virtual string AboutQuote => this.Value<string>(_publishedValueFallback, "aboutQuote");

		///<summary>
		/// About - Section Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSectionTitle")]
		public virtual string AboutSectionTitle => this.Value<string>(_publishedValueFallback, "aboutSectionTitle");

		///<summary>
		/// About - Signature
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSignature")]
		public virtual string AboutSignature => this.Value<string>(_publishedValueFallback, "aboutSignature");

		///<summary>
		/// About - Signature Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutSignatureImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops AboutSignatureImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "aboutSignatureImage");

		///<summary>
		/// About - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutText")]
		public virtual string AboutText => this.Value<string>(_publishedValueFallback, "aboutText");

		///<summary>
		/// Hero - Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops HeroBackgroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "heroBackgroundImage");

		///<summary>
		/// Hero - Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroButtonText")]
		public virtual string HeroButtonText => this.Value<string>(_publishedValueFallback, "heroButtonText");

		///<summary>
		/// Hero - Button Url
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroButtonUrl")]
		public virtual string HeroButtonUrl => this.Value<string>(_publishedValueFallback, "heroButtonUrl");

		///<summary>
		/// Hero - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroHeadline")]
		public virtual string HeroHeadline => this.Value<string>(_publishedValueFallback, "heroHeadline");

		///<summary>
		/// Hero - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("heroText")]
		public virtual string HeroText => this.Value<string>(_publishedValueFallback, "heroText");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Projects - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsHeadline")]
		public virtual string ProjectsHeadline => this.Value<string>(_publishedValueFallback, "projectsHeadline");

		///<summary>
		/// Projects - Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsTitle")]
		public virtual string ProjectsTitle => this.Value<string>(_publishedValueFallback, "projectsTitle");

		///<summary>
		/// Services - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesHeadline")]
		public virtual string ServicesHeadline => this.Value<string>(_publishedValueFallback, "servicesHeadline");

		///<summary>
		/// Services - Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesTitle")]
		public virtual string ServicesTitle => this.Value<string>(_publishedValueFallback, "servicesTitle");

		///<summary>
		/// Success - Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SuccessBackgroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "successBackgroundImage");

		///<summary>
		/// Success -Forefront Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successForefrontImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SuccessForefrontImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "successForefrontImage");

		///<summary>
		/// Success - Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successHeadline")]
		public virtual string SuccessHeadline => this.Value<string>(_publishedValueFallback, "successHeadline");

		///<summary>
		/// Success - Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("successTitle")]
		public virtual string SuccessTitle => this.Value<string>(_publishedValueFallback, "successTitle");

		///<summary>
		/// Trusted - Background Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trustedBackgroundImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops TrustedBackgroundImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "trustedBackgroundImage");

		///<summary>
		/// Trusted - Button Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trustedButtonText")]
		public virtual string TrustedButtonText => this.Value<string>(_publishedValueFallback, "trustedButtonText");

		///<summary>
		/// Trusted - Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trustedDescription")]
		public virtual string TrustedDescription => this.Value<string>(_publishedValueFallback, "trustedDescription");

		///<summary>
		/// Trusted - Forefront Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trustedForefrontImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops TrustedForefrontImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "trustedForefrontImage");

		///<summary>
		/// Trusted - Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trustedText")]
		public virtual string TrustedText => this.Value<string>(_publishedValueFallback, "trustedText");

		///<summary>
		/// Trusted - Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trustedTitle")]
		public virtual string TrustedTitle => this.Value<string>(_publishedValueFallback, "trustedTitle");
	}
}
