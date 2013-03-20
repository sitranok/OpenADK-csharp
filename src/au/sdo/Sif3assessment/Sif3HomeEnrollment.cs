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

/// <summary>A Sif3HomeEnrollment</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3HomeEnrollment : SifElement
{
	/// <summary>
	/// Creates an instance of a Sif3HomeEnrollment
	/// </summary>
	public Sif3HomeEnrollment() : base ( Sif3assessmentDTD.SIF3HOMEENROLLMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="status">A Status</param>
	///<param name="gradeLevel">A GradeLevel</param>
	///
	public Sif3HomeEnrollment( EnrollmentStatus status, YearLevel gradeLevel ) : base( Sif3assessmentDTD.SIF3HOMEENROLLMENT )
	{
		this.SetStatus( status );
		this.GradeLevel = gradeLevel;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3HomeEnrollment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SIF3HOMEENROLLMENT_STATUS, Sif3assessmentDTD.SIF3HOMEENROLLMENT_GRADELEVEL }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentSchoolEnrollmentRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentSchoolEnrollmentRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentSchoolEnrollmentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STUDENTSCHOOLENROLLMENTREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STUDENTSCHOOLENROLLMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SchoolName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_SCHOOLNAME ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_SCHOOLNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_LOCALID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Status&gt;</c> element.
	/// </summary>
	/// <value> The <c>Status</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Status
	{
		get
		{ 
			return GetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STATUS );
		}
		set
		{
			SetField( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Status&gt;</c> element.
	/// </summary>
	/// <param name="val">A EnrollmentStatus object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetStatus( EnrollmentStatus val )
	{
		SetField( Sif3assessmentDTD.SIF3HOMEENROLLMENT_STATUS, val );
	}

	///<summary>Sets the value of the <c>&lt;GradeLevel&gt;</c> element.</summary>
	/// <param name="Code">Code representing the year level.</param>
	///<remarks>
	/// <para>This form of <c>setGradeLevel</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>GradeLevel</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetGradeLevel( YearLevelCode Code ) {
		RemoveChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_GRADELEVEL);
		AddChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_GRADELEVEL, new YearLevel( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevel&gt;</c> element.
	/// </summary>
	/// <value> A YearLevel </value>
	/// <remarks>
	/// <para>To remove the <c>YearLevel</c>, set <c>GradeLevel</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public YearLevel GradeLevel
	{
		get
		{
			return (YearLevel)GetChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_GRADELEVEL);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_GRADELEVEL);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_GRADELEVEL, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Homeroom&gt;</c> element.</summary>
	/// <param name="SifRefObject">A SIF_RefObject</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Sif3Homeroom&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setHomeroom</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Homeroom</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetHomeroom( Sif3HomeroomRefObjEnum SifRefObject, string Value ) {
		RemoveChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOM);
		AddChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOM, new Sif3Homeroom( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Homeroom&gt;</c> element.
	/// </summary>
	/// <value> A Sif3Homeroom </value>
	/// <remarks>
	/// <para>To remove the <c>Sif3Homeroom</c>, set <c>Homeroom</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public Sif3Homeroom Homeroom
	{
		get
		{
			return (Sif3Homeroom)GetChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOM);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOM);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOM, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HomeroomNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>HomeroomNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string HomeroomNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOMNUMBER ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_HOMEROOMNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FullYearEnrollment&gt;</c> element.
	/// </summary>
	/// <value> The <c>FullYearEnrollment</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string FullYearEnrollment
	{
		get
		{ 
			return GetFieldValue( Sif3assessmentDTD.SIF3HOMEENROLLMENT_FULLYEARENROLLMENT );
		}
		set
		{
			SetField( Sif3assessmentDTD.SIF3HOMEENROLLMENT_FULLYEARENROLLMENT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;FullYearEnrollment&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetFullYearEnrollment( YesNoUnknown val )
	{
		SetField( Sif3assessmentDTD.SIF3HOMEENROLLMENT_FULLYEARENROLLMENT, val );
	}

}}
