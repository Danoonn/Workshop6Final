﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Company.Workshop8
{
	/// <summary>
	/// DomainClass Relationship
	/// Description for Company.Workshop8.Relationship
	/// </summary>
	[DslDesign::DisplayNameResource("Company.Workshop8.Relationship.DisplayName", typeof(global::Company.Workshop8.Workshop8DomainModel), "Company.Workshop8.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.Workshop8.Relationship.Description", typeof(global::Company.Workshop8.Workshop8DomainModel), "Company.Workshop8.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Company.Workshop8.Workshop8DomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("b3674be0-2005-4e0b-a5df-12c1da95f9d1")]
	public partial class Relationship : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with Relationship.
		/// </summary>
		public static DslDiagrams::Decorator FindRelationshipDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorEmptyArrow, new DslDiagrams::SizeD(0.1,0.1), false);
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// Relationship domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xb3674be0, 0x2005, 0x4e0b, 0xa5, 0xdf, 0x12, 0xc1, 0xda, 0x95, 0xf9, 0xd1);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Relationship(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Relationship(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace Company.Workshop8
{
	/// <summary>
	/// DomainClass RelationshipShape
	/// Description for Company.Workshop8.RelationshipShape
	/// </summary>
	[DslDesign::DisplayNameResource("Company.Workshop8.RelationshipShape.DisplayName", typeof(global::Company.Workshop8.Workshop8DomainModel), "Company.Workshop8.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.Workshop8.RelationshipShape.Description", typeof(global::Company.Workshop8.Workshop8DomainModel), "Company.Workshop8.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Company.Workshop8.Workshop8DomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("cd377b49-28ef-49ab-8b62-9b8d2d70b517")]
	public partial class RelationshipShape : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with RelationshipShape.
		/// </summary>
		public static DslDiagrams::Decorator FindRelationshipShapeDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Color = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.DimGray);
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLineDecorator, linePen);
			linePen.Width = 0.02f;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
			DslDiagrams::BrushSettings lineBrush = new DslDiagrams::BrushSettings();
			lineBrush.Color = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.DimGray);
			classStyleSet.OverrideBrush(DslDiagrams::DiagramBrushes.ConnectionLineDecorator, lineBrush);
			
		}
		
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorFilledArrow, new DslDiagrams::SizeD(0.1,0.1), false);
		}
		
		/// <summary>
		/// Gets the default line routing style for this connector.
		/// </summary>
		[global::System.CLSCompliant(false)]
		protected override DslDiagrams::GraphObject.VGRoutingStyle DefaultRoutingStyle
		{
			get
			{
				return DslDiagrams::GraphObject.VGRoutingStyle.VGRouteStraight;
			}
		}
		#endregion
		
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("SignShape");
			field1.DefaultText = global::Company.Workshop8.Workshop8DomainModel.SingletonResourceManager.GetString("RelationshipShapeSignShapeDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ConnectorDecorator(field1, DslDiagrams::ConnectorDecoratorPosition.SourceTop, DslDiagrams::PointD.Empty);
			decorators.Add(decorator1);
				
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// RelationshipShape domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xcd377b49, 0x28ef, 0x49ab, 0x8b, 0x62, 0x9b, 0x8d, 0x2d, 0x70, 0xb5, 0x17);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public RelationshipShape(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public RelationshipShape(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
