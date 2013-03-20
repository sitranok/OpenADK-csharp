// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A Sif3AssessmentForm</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3AssessmentForm : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3AssessmentForm
	/// </summary>
	public Sif3AssessmentForm() : base( Adk.SifVersion, Sif3assessmentDTD.SIF3ASSESSMENTFORM ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="assessmentRefId">An AssessmentRefId</param>
	///<param name="formName">A FormName</param>
	///
	public Sif3AssessmentForm( string refId, string assessmentRefId, string formName ) : base( Adk.SifVersion, Sif3assessmentDTD.SIF3ASSESSMENTFORM )
	{
		this.RefId = refId;
		this.AssessmentRefId = assessmentRefId;
		this.FormName = formName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3AssessmentForm( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SIF3ASSESSMENTFORM_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_REFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormVersion&gt;</c> element.
	/// </summary>
	/// <value> The <c>FormVersion</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string FormVersion
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMVERSION ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMVERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormPublishDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>FormPublishDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? FormPublishDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMPUBLISHDATE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMPUBLISHDATE, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentType&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentType</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AssessmentType
	{
		get
		{ 
			return GetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTTYPE );
		}
		set
		{
			SetField( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AssessmentType&gt;</c> element.
	/// </summary>
	/// <param name="val">A AssessmentType object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentType( AssessmentType val )
	{
		SetField( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormName&gt;</c> element.
	/// </summary>
	/// <value> The <c>FormName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string FormName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMNAME ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;FormIdentifiers&gt;</c> element.</summary>
	/// <param name="FormIdentifier">A FormIdentifier</param>
	///<remarks>
	/// <para>This form of <c>setFormIdentifiers</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>FormIdentifiers</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetFormIdentifiers( FormIdentifier FormIdentifier ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMIDENTIFIERS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMIDENTIFIERS, new FormIdentifierList( FormIdentifier ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormIdentifiers&gt;</c> element.
	/// </summary>
	/// <value> A FormIdentifierList </value>
	/// <remarks>
	/// <para>To remove the <c>FormIdentifierList</c>, set <c>FormIdentifiers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public FormIdentifierList FormIdentifiers
	{
		get
		{
			return (FormIdentifierList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMIDENTIFIERS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMIDENTIFIERS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMIDENTIFIERS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;FormAccommodations&gt;</c> element.</summary>
	/// <param name="FormAccommodation">A FormAccommodation</param>
	///<remarks>
	/// <para>This form of <c>setFormAccommodations</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>FormAccommodations</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetFormAccommodations( FormAccommodation FormAccommodation ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMACCOMMODATIONS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMACCOMMODATIONS, new FormAccommodationList( FormAccommodation ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormAccommodations&gt;</c> element.
	/// </summary>
	/// <value> A FormAccommodationList </value>
	/// <remarks>
	/// <para>To remove the <c>FormAccommodationList</c>, set <c>FormAccommodations</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public FormAccommodationList FormAccommodations
	{
		get
		{
			return (FormAccommodationList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMACCOMMODATIONS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMACCOMMODATIONS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_FORMACCOMMODATIONS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Level&gt;</c> element.
	/// </summary>
	/// <value> The <c>Level</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Level
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_LEVEL ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_LEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Period&gt;</c> element.
	/// </summary>
	/// <value> The <c>Period</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Period
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_PERIOD ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3ASSESSMENTFORM_PERIOD, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;GradeLevels&gt;</c> element.</summary>
	/// <param name="YearLevel">A YearLevel</param>
	///<remarks>
	/// <para>This form of <c>setGradeLevels</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GradeLevels</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetGradeLevels( YearLevel YearLevel ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_GRADELEVELS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_GRADELEVELS, new YearLevels( YearLevel ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A YearLevels </value>
	/// <remarks>
	/// <para>To remove the <c>YearLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public YearLevels GradeLevels
	{
		get
		{
			return (YearLevels)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_GRADELEVELS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_GRADELEVELS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_GRADELEVELS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentFormSubjects&gt;</c> element.</summary>
	/// <param name="SubjectArea">Subject matter.</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentFormSubjects</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentFormSubjects</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentFormSubjects( SubjectArea SubjectArea ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMSUBJECTS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMSUBJECTS, new SubjectAreaList( SubjectArea ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentFormSubjects&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreaList </value>
	/// <remarks>
	/// <para>To remove the <c>SubjectAreaList</c>, set <c>AssessmentFormSubjects</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public SubjectAreaList AssessmentFormSubjects
	{
		get
		{
			return (SubjectAreaList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMSUBJECTS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMSUBJECTS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMSUBJECTS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentFormLanguages&gt;</c> element.</summary>
	/// <param name="Language">A Language</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentFormLanguages</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentFormLanguages</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentFormLanguages( Language Language ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMLANGUAGES);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMLANGUAGES, new LanguageList( Language ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentFormLanguages&gt;</c> element.
	/// </summary>
	/// <value> A LanguageList </value>
	/// <remarks>
	/// <para>To remove the <c>LanguageList</c>, set <c>AssessmentFormLanguages</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public LanguageList AssessmentFormLanguages
	{
		get
		{
			return (LanguageList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMLANGUAGES);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMLANGUAGES);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTFORMLANGUAGES, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentSubTestRefIds&gt;</c> element.</summary>
	/// <param name="AssessmentSubTestRefId">An AssessmentSubTestRefId</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentSubTestRefIds</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentSubTestRefIds</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentSubTestRefIds( Sif3AssessmentSubTestRefId AssessmentSubTestRefId ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS, new Sif3AssessmentSubTestRefIds( AssessmentSubTestRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSubTestRefIds&gt;</c> element.
	/// </summary>
	/// <value> A Sif3AssessmentSubTestRefIds </value>
	/// <remarks>
	/// <para>To remove the <c>Sif3AssessmentSubTestRefIds</c>, set <c>AssessmentSubTestRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public Sif3AssessmentSubTestRefIds AssessmentSubTestRefIds
	{
		get
		{
			return (Sif3AssessmentSubTestRefIds)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentSections&gt;</c> element.</summary>
	/// <param name="AssessmentSection">An AssessmentSection</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentSections</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentSections</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentSections( AssessmentSection AssessmentSection ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSECTIONS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSECTIONS, new AssessmentSectionList( AssessmentSection ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSections&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentSectionList </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentSectionList</c>, set <c>AssessmentSections</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentSectionList AssessmentSections
	{
		get
		{
			return (AssessmentSectionList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSECTIONS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSECTIONS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTSECTIONS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentPlatforms&gt;</c> element.</summary>
	/// <param name="AssessmentPlatform">An AssessmentPlatform</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentPlatforms</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentPlatforms</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentPlatforms( AssessmentPlatform AssessmentPlatform ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTPLATFORMS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTPLATFORMS, new AssessmentPlatformList( AssessmentPlatform ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentPlatforms&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentPlatformList </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentPlatformList</c>, set <c>AssessmentPlatforms</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentPlatformList AssessmentPlatforms
	{
		get
		{
			return (AssessmentPlatformList)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTPLATFORMS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTPLATFORMS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTPLATFORMS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentAssetRefIds&gt;</c> element.</summary>
	/// <param name="AssessmentAssetRefId">An AssessmentAssetRefId</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentAssetRefIds</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentAssetRefIds</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentAssetRefIds( AssessmentAssetRefId AssessmentAssetRefId ) {
		RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTASSETREFIDS);
		AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTASSETREFIDS, new AssessmentAssetRefIds( AssessmentAssetRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentAssetRefIds&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentAssetRefIds </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentAssetRefIds</c>, set <c>AssessmentAssetRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentAssetRefIds AssessmentAssetRefIds
	{
		get
		{
			return (AssessmentAssetRefIds)GetChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTASSETREFIDS);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTASSETREFIDS);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3ASSESSMENTFORM_ASSESSMENTASSETREFIDS, value );
			}
		}
	}

}}
