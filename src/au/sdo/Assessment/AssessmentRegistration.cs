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

namespace OpenADK.Library.au.Assessment{

/// <summary>An AssessmentRegistration</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class AssessmentRegistration : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AssessmentRegistration
	/// </summary>
	public AssessmentRegistration() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTREGISTRATION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="studentPersonalRefId">The student associated with the registration.</param>
	///<param name="assessmentAdministrationRefId">The assessment administration associated with the registration.</param>
	///<param name="creationDateTime">Date/time assignment is made.</param>
	///
	public AssessmentRegistration( string refId, string studentPersonalRefId, string assessmentAdministrationRefId, DateTime? creationDateTime ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTREGISTRATION )
	{
		this.RefId = refId;
		this.StudentPersonalRefId = studentPersonalRefId;
		this.AssessmentAdministrationRefId = assessmentAdministrationRefId;
		this.CreationDateTime = creationDateTime;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentRegistration( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTREGISTRATION_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The student associated with the registration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentAdministrationRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentAdministrationRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The assessment administration associated with the registration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string AssessmentAdministrationRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTADMINISTRATIONREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTADMINISTRATIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationDateTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreationDateTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date/time assignment is made."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? CreationDateTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_CREATIONDATETIME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_CREATIONDATETIME, new SifDateTime( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;StudentSpecialConditions&gt;</c> element.</summary>
	/// <param name="StudentSpecialCondition">A description of the special condition.  Student special conditions are different
	/// from special conditions of the test.</param>
	///<remarks>
	/// <para>This form of <c>setStudentSpecialConditions</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>StudentSpecialConditions</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetStudentSpecialConditions( StudentSpecialCondition StudentSpecialCondition ) {
		RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTSPECIALCONDITIONS);
		AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTSPECIALCONDITIONS, new StudentSpecialConditions( StudentSpecialCondition ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentSpecialConditions&gt;</c> element.
	/// </summary>
	/// <value> A StudentSpecialConditions </value>
	/// <remarks>
	/// <para>To remove the <c>StudentSpecialConditions</c>, set <c>StudentSpecialConditions</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public StudentSpecialConditions StudentSpecialConditions
	{
		get
		{
			return (StudentSpecialConditions)GetChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTSPECIALCONDITIONS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTSPECIALCONDITIONS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTSPECIALCONDITIONS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;StudentYearLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the year level.</param>
	///<remarks>
	/// <para>This form of <c>setStudentYearLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>StudentYearLevel</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetStudentYearLevel( YearLevelCode Code ) {
		RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTYEARLEVEL);
		AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTYEARLEVEL, new YearLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentYearLevel&gt;</c> element.
	/// </summary>
	/// <value> A YearLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Grade level of the student at the time of testing."</para>
	/// <para>To remove the <c>YearLevel</c>, set <c>StudentYearLevel</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public YearLevel StudentYearLevel
	{
		get
		{
			return (YearLevel)GetChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTYEARLEVEL);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTYEARLEVEL);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_STUDENTYEARLEVEL, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentYearLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the year level.</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentYearLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentYearLevel</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetAssessmentYearLevel( YearLevelCode Code ) {
		RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTYEARLEVEL);
		AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTYEARLEVEL, new YearLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentYearLevel&gt;</c> element.
	/// </summary>
	/// <value> A YearLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The grade or level at which the student is to be tested. This element should be omitted unless the student is being tested out-of-level."</para>
	/// <para>To remove the <c>YearLevel</c>, set <c>AssessmentYearLevel</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public YearLevel AssessmentYearLevel
	{
		get
		{
			return (YearLevel)GetChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTYEARLEVEL);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTYEARLEVEL);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTYEARLEVEL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentStudentSnapshot&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentStudentSnapshot </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentStudentSnapshot</c>, set <c>AssessmentStudentSnapshot</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public AssessmentStudentSnapshot AssessmentStudentSnapshot
	{
		get
		{
			return (AssessmentStudentSnapshot)GetChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTSTUDENTSNAPSHOT);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTSTUDENTSNAPSHOT);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTREGISTRATION_ASSESSMENTSTUDENTSNAPSHOT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LEAInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LEAInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional reference to a district associated with the registration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string LEAInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_LEAINFOREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_LEAINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional reference to a school associated with the registration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StaffPersonalRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StaffPersonalRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Optional reference to a staff person associated with the registration."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string StaffPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_STAFFPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTREGISTRATION_STAFFPERSONALREFID, new SifString( value ), value );
		}
	}

}}
