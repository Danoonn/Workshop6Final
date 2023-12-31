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
	/// DomainModel Workshop8DomainModel
	/// Description for Company.Workshop8.Workshop8
	/// </summary>
	[DslDesign::DisplayNameResource("Company.Workshop8.Workshop8DomainModel.DisplayName", typeof(global::Company.Workshop8.Workshop8DomainModel), "Company.Workshop8.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.Workshop8.Workshop8DomainModel.Description", typeof(global::Company.Workshop8.Workshop8DomainModel), "Company.Workshop8.GeneratedCode.DomainModelResx")]
	[global::System.CLSCompliant(true)]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.CoreDomainModel))]
	[DslModeling::DependsOnDomainModel(typeof(global::Microsoft.VisualStudio.Modeling.Diagrams.CoreDesignSurfaceDomainModel))]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
	[DslModeling::DomainObjectId("ef95c8a3-f7b5-4d28-a0d2-9a5d2f0b8519")]
	public partial class Workshop8DomainModel : DslModeling::DomainModel
	{
		#region Constructor, domain model Id
	
		/// <summary>
		/// Workshop8DomainModel domain model Id.
		/// </summary>
		public static readonly global::System.Guid DomainModelId = new global::System.Guid(0xef95c8a3, 0xf7b5, 0x4d28, 0xa0, 0xd2, 0x9a, 0x5d, 0x2f, 0x0b, 0x85, 0x19);
	
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="store">Store containing the domain model.</param>
		public Workshop8DomainModel(DslModeling::Store store)
			: base(store, DomainModelId)
		{
			// Call the partial method to allow any required serialization setup to be done.
			this.InitializeSerialization(store);		
		}
		
	
		///<Summary>
		/// Defines a partial method that will be called from the constructor to
		/// allow any necessary serialization setup to be done.
		///</Summary>
		///<remarks>
		/// For a DSL created with the DSL Designer wizard, an implementation of this 
		/// method will be generated in the GeneratedCode\SerializationHelper.cs class.
		///</remarks>
		partial void InitializeSerialization(DslModeling::Store store);
	
	
		#endregion
		#region Domain model reflection
			
		/// <summary>
		/// Gets the list of generated domain model types (classes, rules, relationships).
		/// </summary>
		/// <returns>List of types.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override global::System.Type[] GetGeneratedDomainModelTypes()
		{
			return new global::System.Type[]
			{
				typeof(SoftwareArchitecture),
				typeof(ImpactLevel),
				typeof(Structural),
				typeof(Enabling),
				typeof(Immediate),
				typeof(Concern),
				typeof(EconomicConcern),
				typeof(SocialConcern),
				typeof(EnvironmentalConcern),
				typeof(TechnicalConcern),
				typeof(SoftwareSolution),
				typeof(Legend),
				typeof(SoftwareArchitectureHasElements),
				typeof(ImpactLevelHasConcern),
				typeof(ConcernReferencesTargetConcern),
				typeof(SoftwareArchitectureHasLegend),
				typeof(Workshop8Diagram),
				typeof(Relationship),
				typeof(RelationshipShape),
				typeof(ExampleShape),
				typeof(StructuralShape),
				typeof(EnablingShape),
				typeof(ImmediateShape),
				typeof(EconomicConcernShape),
				typeof(SocialConcernShape),
				typeof(EnvironmentalConcernShape),
				typeof(TechnicalConcernShape),
				typeof(SoftwareSolutionShape),
				typeof(ConcernShape),
				typeof(LegendShape),
				typeof(global::Company.Workshop8.FixUpDiagram),
				typeof(global::Company.Workshop8.DecoratorPropertyChanged),
				typeof(global::Company.Workshop8.ConnectorRolePlayerChanged),
			};
		}
		/// <summary>
		/// Gets the list of generated domain properties.
		/// </summary>
		/// <returns>List of property data.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		protected sealed override DomainMemberInfo[] GetGeneratedDomainProperties()
		{
			return new DomainMemberInfo[]
			{
				new DomainMemberInfo(typeof(ImpactLevel), "Name", ImpactLevel.NameDomainPropertyId, typeof(ImpactLevel.NamePropertyHandler)),
				new DomainMemberInfo(typeof(Structural), "StructuralName", Structural.StructuralNameDomainPropertyId, typeof(Structural.StructuralNamePropertyHandler)),
				new DomainMemberInfo(typeof(Enabling), "EnablingName", Enabling.EnablingNameDomainPropertyId, typeof(Enabling.EnablingNamePropertyHandler)),
				new DomainMemberInfo(typeof(Immediate), "ImmediateName", Immediate.ImmediateNameDomainPropertyId, typeof(Immediate.ImmediateNamePropertyHandler)),
				new DomainMemberInfo(typeof(Concern), "ConcernName", Concern.ConcernNameDomainPropertyId, typeof(Concern.ConcernNamePropertyHandler)),
				new DomainMemberInfo(typeof(EconomicConcern), "EcoName", EconomicConcern.EcoNameDomainPropertyId, typeof(EconomicConcern.EcoNamePropertyHandler)),
				new DomainMemberInfo(typeof(SocialConcern), "SocialName", SocialConcern.SocialNameDomainPropertyId, typeof(SocialConcern.SocialNamePropertyHandler)),
				new DomainMemberInfo(typeof(EnvironmentalConcern), "EnvironmentalName", EnvironmentalConcern.EnvironmentalNameDomainPropertyId, typeof(EnvironmentalConcern.EnvironmentalNamePropertyHandler)),
				new DomainMemberInfo(typeof(TechnicalConcern), "TechName", TechnicalConcern.TechNameDomainPropertyId, typeof(TechnicalConcern.TechNamePropertyHandler)),
				new DomainMemberInfo(typeof(SoftwareSolution), "SoSolutionName", SoftwareSolution.SoSolutionNameDomainPropertyId, typeof(SoftwareSolution.SoSolutionNamePropertyHandler)),
				new DomainMemberInfo(typeof(ConcernReferencesTargetConcern), "Sign", ConcernReferencesTargetConcern.SignDomainPropertyId, typeof(ConcernReferencesTargetConcern.SignPropertyHandler)),
			};
		}
		/// <summary>
		/// Gets the list of generated domain roles.
		/// </summary>
		/// <returns>List of role data.</returns>
		protected sealed override DomainRolePlayerInfo[] GetGeneratedDomainRoles()
		{
			return new DomainRolePlayerInfo[]
			{
				new DomainRolePlayerInfo(typeof(SoftwareArchitectureHasElements), "SoftwareArchitecture", SoftwareArchitectureHasElements.SoftwareArchitectureDomainRoleId),
				new DomainRolePlayerInfo(typeof(SoftwareArchitectureHasElements), "Element", SoftwareArchitectureHasElements.ElementDomainRoleId),
				new DomainRolePlayerInfo(typeof(ImpactLevelHasConcern), "ImpactLevel", ImpactLevelHasConcern.ImpactLevelDomainRoleId),
				new DomainRolePlayerInfo(typeof(ImpactLevelHasConcern), "Concern", ImpactLevelHasConcern.ConcernDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConcernReferencesTargetConcern), "SourceConcern", ConcernReferencesTargetConcern.SourceConcernDomainRoleId),
				new DomainRolePlayerInfo(typeof(ConcernReferencesTargetConcern), "TargetConcern", ConcernReferencesTargetConcern.TargetConcernDomainRoleId),
				new DomainRolePlayerInfo(typeof(SoftwareArchitectureHasLegend), "SoftwareArchitecture", SoftwareArchitectureHasLegend.SoftwareArchitectureDomainRoleId),
				new DomainRolePlayerInfo(typeof(SoftwareArchitectureHasLegend), "Legend", SoftwareArchitectureHasLegend.LegendDomainRoleId),
			};
		}
		#endregion
		#region Factory methods
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementMap;
	
		/// <summary>
		/// Creates an element of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementType">Element type which belongs to this domain model.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]	
		public sealed override DslModeling::ModelElement CreateElement(DslModeling::Partition partition, global::System.Type elementType, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementType == null) throw new global::System.ArgumentNullException("elementType");
	
			if (createElementMap == null)
			{
				createElementMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(26);
				createElementMap.Add(typeof(SoftwareArchitecture), 0);
				createElementMap.Add(typeof(ImpactLevel), 1);
				createElementMap.Add(typeof(Structural), 2);
				createElementMap.Add(typeof(Enabling), 3);
				createElementMap.Add(typeof(Immediate), 4);
				createElementMap.Add(typeof(Concern), 5);
				createElementMap.Add(typeof(EconomicConcern), 6);
				createElementMap.Add(typeof(SocialConcern), 7);
				createElementMap.Add(typeof(EnvironmentalConcern), 8);
				createElementMap.Add(typeof(TechnicalConcern), 9);
				createElementMap.Add(typeof(SoftwareSolution), 10);
				createElementMap.Add(typeof(Legend), 11);
				createElementMap.Add(typeof(Workshop8Diagram), 12);
				createElementMap.Add(typeof(Relationship), 13);
				createElementMap.Add(typeof(RelationshipShape), 14);
				createElementMap.Add(typeof(ExampleShape), 15);
				createElementMap.Add(typeof(StructuralShape), 16);
				createElementMap.Add(typeof(EnablingShape), 17);
				createElementMap.Add(typeof(ImmediateShape), 18);
				createElementMap.Add(typeof(EconomicConcernShape), 19);
				createElementMap.Add(typeof(SocialConcernShape), 20);
				createElementMap.Add(typeof(EnvironmentalConcernShape), 21);
				createElementMap.Add(typeof(TechnicalConcernShape), 22);
				createElementMap.Add(typeof(SoftwareSolutionShape), 23);
				createElementMap.Add(typeof(ConcernShape), 24);
				createElementMap.Add(typeof(LegendShape), 25);
			}
			int index;
			if (!createElementMap.TryGetValue(elementType, out index))
			{
				// construct exception error message		
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Company.Workshop8.Workshop8DomainModel.SingletonResourceManager.GetString("UnrecognizedElementType"),
								elementType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementType");
			}
			switch (index)
			{
				case 0: return new SoftwareArchitecture(partition, propertyAssignments);
				case 1: return new ImpactLevel(partition, propertyAssignments);
				case 2: return new Structural(partition, propertyAssignments);
				case 3: return new Enabling(partition, propertyAssignments);
				case 4: return new Immediate(partition, propertyAssignments);
				case 5: return new Concern(partition, propertyAssignments);
				case 6: return new EconomicConcern(partition, propertyAssignments);
				case 7: return new SocialConcern(partition, propertyAssignments);
				case 8: return new EnvironmentalConcern(partition, propertyAssignments);
				case 9: return new TechnicalConcern(partition, propertyAssignments);
				case 10: return new SoftwareSolution(partition, propertyAssignments);
				case 11: return new Legend(partition, propertyAssignments);
				case 12: return new Workshop8Diagram(partition, propertyAssignments);
				case 13: return new Relationship(partition, propertyAssignments);
				case 14: return new RelationshipShape(partition, propertyAssignments);
				case 15: return new ExampleShape(partition, propertyAssignments);
				case 16: return new StructuralShape(partition, propertyAssignments);
				case 17: return new EnablingShape(partition, propertyAssignments);
				case 18: return new ImmediateShape(partition, propertyAssignments);
				case 19: return new EconomicConcernShape(partition, propertyAssignments);
				case 20: return new SocialConcernShape(partition, propertyAssignments);
				case 21: return new EnvironmentalConcernShape(partition, propertyAssignments);
				case 22: return new TechnicalConcernShape(partition, propertyAssignments);
				case 23: return new SoftwareSolutionShape(partition, propertyAssignments);
				case 24: return new ConcernShape(partition, propertyAssignments);
				case 25: return new LegendShape(partition, propertyAssignments);
				default: return null;
			}
		}
	
		private static global::System.Collections.Generic.Dictionary<global::System.Type, int> createElementLinkMap;
	
		/// <summary>
		/// Creates an element link of specified type.
		/// </summary>
		/// <param name="partition">Partition where element is to be created.</param>
		/// <param name="elementLinkType">Element link type which belongs to this domain model.</param>
		/// <param name="roleAssignments">List of relationship role assignments for the new link.</param>
		/// <param name="propertyAssignments">New element property assignments.</param>
		/// <returns>Created element link.</returns>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		public sealed override DslModeling::ElementLink CreateElementLink(DslModeling::Partition partition, global::System.Type elementLinkType, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
		{
			if (elementLinkType == null) throw new global::System.ArgumentNullException("elementLinkType");
			if (roleAssignments == null) throw new global::System.ArgumentNullException("roleAssignments");
	
			if (createElementLinkMap == null)
			{
				createElementLinkMap = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(4);
				createElementLinkMap.Add(typeof(SoftwareArchitectureHasElements), 0);
				createElementLinkMap.Add(typeof(ImpactLevelHasConcern), 1);
				createElementLinkMap.Add(typeof(ConcernReferencesTargetConcern), 2);
				createElementLinkMap.Add(typeof(SoftwareArchitectureHasLegend), 3);
			}
			int index;
			if (!createElementLinkMap.TryGetValue(elementLinkType, out index))
			{
				// construct exception error message
				string exceptionError = string.Format(
								global::System.Globalization.CultureInfo.CurrentCulture,
								global::Company.Workshop8.Workshop8DomainModel.SingletonResourceManager.GetString("UnrecognizedElementLinkType"),
								elementLinkType.Name);
				throw new global::System.ArgumentException(exceptionError, "elementLinkType");
			
			}
			switch (index)
			{
				case 0: return new SoftwareArchitectureHasElements(partition, roleAssignments, propertyAssignments);
				case 1: return new ImpactLevelHasConcern(partition, roleAssignments, propertyAssignments);
				case 2: return new ConcernReferencesTargetConcern(partition, roleAssignments, propertyAssignments);
				case 3: return new SoftwareArchitectureHasLegend(partition, roleAssignments, propertyAssignments);
				default: return null;
			}
		}
		#endregion
		#region Resource manager
		
		private static global::System.Resources.ResourceManager resourceManager;
		
		/// <summary>
		/// The base name of this model's resources.
		/// </summary>
		public const string ResourceBaseName = "Company.Workshop8.GeneratedCode.DomainModelResx";
		
		/// <summary>
		/// Gets the DomainModel's ResourceManager. If the ResourceManager does not already exist, then it is created.
		/// </summary>
		public override global::System.Resources.ResourceManager ResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return Workshop8DomainModel.SingletonResourceManager;
			}
		}
	
		/// <summary>
		/// Gets the Singleton ResourceManager for this domain model.
		/// </summary>
		public static global::System.Resources.ResourceManager SingletonResourceManager
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				if (Workshop8DomainModel.resourceManager == null)
				{
					Workshop8DomainModel.resourceManager = new global::System.Resources.ResourceManager(ResourceBaseName, typeof(Workshop8DomainModel).Assembly);
				}
				return Workshop8DomainModel.resourceManager;
			}
		}
		#endregion
		#region Copy/Remove closures
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter copyClosure;
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter removeClosure;
		/// <summary>
		/// Returns an IElementVisitorFilter that corresponds to the ClosureType.
		/// </summary>
		/// <param name="type">closure type</param>
		/// <param name="rootElements">collection of root elements</param>
		/// <returns>IElementVisitorFilter or null</returns>
		public override DslModeling::IElementVisitorFilter GetClosureFilter(DslModeling::ClosureType type, global::System.Collections.Generic.ICollection<DslModeling::ModelElement> rootElements)
		{
			switch (type)
			{
				case DslModeling::ClosureType.CopyClosure:
					return Workshop8DomainModel.CopyClosure;
				case DslModeling::ClosureType.DeleteClosure:
					return Workshop8DomainModel.DeleteClosure;
			}
			return base.GetClosureFilter(type, rootElements);
		}
		/// <summary>
		/// CopyClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter CopyClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (Workshop8DomainModel.copyClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter copyFilter = new DslModeling::ChainingElementVisitorFilter();
					copyFilter.AddFilter(new Workshop8CopyClosure());
					copyFilter.AddFilter(new DslModeling::CoreCopyClosure());
					copyFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceCopyClosure());
					
					Workshop8DomainModel.copyClosure = copyFilter;
				}
				return Workshop8DomainModel.copyClosure;
			}
		}
		/// <summary>
		/// DeleteClosure cache
		/// </summary>
		private static DslModeling::IElementVisitorFilter DeleteClosure
		{
			get
			{
				// Incorporate all of the closures from the models we extend
				if (Workshop8DomainModel.removeClosure == null)
				{
					DslModeling::ChainingElementVisitorFilter removeFilter = new DslModeling::ChainingElementVisitorFilter();
					removeFilter.AddFilter(new Workshop8DeleteClosure());
					removeFilter.AddFilter(new DslModeling::CoreDeleteClosure());
					removeFilter.AddFilter(new DslDiagrams::CoreDesignSurfaceDeleteClosure());
		
					Workshop8DomainModel.removeClosure = removeFilter;
				}
				return Workshop8DomainModel.removeClosure;
			}
		}
		#endregion
		#region Diagram rule helpers
		/// <summary>
		/// Enables rules in this domain model related to diagram fixup for the given store.
		/// If diagram data will be loaded into the store, this method should be called first to ensure
		/// that the diagram behaves properly.
		/// </summary>
		public static void EnableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.EnableRule(typeof(global::Company.Workshop8.FixUpDiagram));
			ruleManager.EnableRule(typeof(global::Company.Workshop8.DecoratorPropertyChanged));
			ruleManager.EnableRule(typeof(global::Company.Workshop8.ConnectorRolePlayerChanged));
		}
		
		/// <summary>
		/// Disables rules in this domain model related to diagram fixup for the given store.
		/// </summary>
		public static void DisableDiagramRules(DslModeling::Store store)
		{
			if(store == null) throw new global::System.ArgumentNullException("store");
			
			DslModeling::RuleManager ruleManager = store.RuleManager;
			ruleManager.DisableRule(typeof(global::Company.Workshop8.FixUpDiagram));
			ruleManager.DisableRule(typeof(global::Company.Workshop8.DecoratorPropertyChanged));
			ruleManager.DisableRule(typeof(global::Company.Workshop8.ConnectorRolePlayerChanged));
		}
		#endregion
	}
		
	#region Copy/Remove closure classes
	/// <summary>
	/// Remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class Workshop8DeleteClosure : Workshop8DeleteClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Workshop8DeleteClosure() : base()
		{
		}
	}
	
	/// <summary>
	/// Base class for remove closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class Workshop8DeleteClosureBase : DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary domainRoles;
		/// <summary>
		/// Constructor
		/// </summary>
		public Workshop8DeleteClosureBase()
		{
			#region Initialize DomainData Table
			DomainRoles.Add(global::Company.Workshop8.SoftwareArchitectureHasElements.ElementDomainRoleId, true);
			DomainRoles.Add(global::Company.Workshop8.ImpactLevelHasConcern.ConcernDomainRoleId, true);
			DomainRoles.Add(global::Company.Workshop8.SoftwareArchitectureHasLegend.LegendDomainRoleId, true);
			#endregion
		}
		/// <summary>
		/// Called to ask the filter if a particular relationship from a source element should be included in the traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="sourceRoleInfo">DomainRoleInfo of the role that the source element is playing in the relationship</param>
		/// <param name="domainRelationshipInfo">DomainRelationshipInfo for the ElementLink in question</param>
		/// <param name="targetRelationship">Relationship in question</param>
		/// <returns>Yes if the relationship should be traversed</returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRelationship(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::DomainRoleInfo sourceRoleInfo, DslModeling::DomainRelationshipInfo domainRelationshipInfo, DslModeling::ElementLink targetRelationship)
		{
			return DslModeling::VisitorFilterResult.Yes;
		}
		/// <summary>
		/// Called to ask the filter if a particular role player should be Visited during traversal
		/// </summary>
		/// <param name="walker">ElementWalker that is traversing the model</param>
		/// <param name="sourceElement">Model Element playing the source role</param>
		/// <param name="elementLink">Element Link that forms the relationship to the role player in question</param>
		/// <param name="targetDomainRole">DomainRoleInfo of the target role</param>
		/// <param name="targetRolePlayer">Model Element that plays the target role in the relationship</param>
		/// <returns></returns>
		public virtual DslModeling::VisitorFilterResult ShouldVisitRolePlayer(DslModeling::ElementWalker walker, DslModeling::ModelElement sourceElement, DslModeling::ElementLink elementLink, DslModeling::DomainRoleInfo targetDomainRole, DslModeling::ModelElement targetRolePlayer)
		{
			if (targetDomainRole == null) throw new global::System.ArgumentNullException("targetDomainRole");
			return this.DomainRoles.Contains(targetDomainRole.Id) ? DslModeling::VisitorFilterResult.Yes : DslModeling::VisitorFilterResult.DoNotCare;
		}
		/// <summary>
		/// DomainRoles
		/// </summary>
		private global::System.Collections.Specialized.HybridDictionary DomainRoles
		{
			get
			{
				if (this.domainRoles == null)
				{
					this.domainRoles = new global::System.Collections.Specialized.HybridDictionary();
				}
				return this.domainRoles;
			}
		}
	
	}
	/// <summary>
	/// Copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class Workshop8CopyClosure : Workshop8CopyClosureBase, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Workshop8CopyClosure() : base()
		{
		}
	}
	/// <summary>
	/// Base class for copy closure visitor filter
	/// </summary>
	[global::System.CLSCompliant(true)]
	public partial class Workshop8CopyClosureBase : DslModeling::CopyClosureFilter, DslModeling::IElementVisitorFilter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Workshop8CopyClosureBase():base()
		{
		}
	}
	#endregion
		
}

