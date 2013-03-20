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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Assessment{

/// <summary>An AssessmentStudentSnapshot</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.2</para>
/// </remarks>
[Serializable]
public class AssessmentStudentSnapshot : SifElement
{
	/// <summary>
	/// Creates an instance of an AssessmentStudentSnapshot
	/// </summary>
	public AssessmentStudentSnapshot() : base ( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentStudentSnapshot( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;RaceList&gt;</c> element.
	/// </summary>
	/// <value> A RaceList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Person's race"</para>
	/// <para>To remove the <c>RaceList</c>, set <c>RaceList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public RaceList RaceList
	{
		get
		{
			return (RaceList)GetChild( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_RACELIST);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_RACELIST);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_RACELIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HispanicLatino&gt;</c> element.
	/// </summary>
	/// <value> The <c>HispanicLatino</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string HispanicLatino
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_HISPANICLATINO );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_HISPANICLATINO, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;HispanicLatino&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetHispanicLatino( YesNo val )
	{
		SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_HISPANICLATINO, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Gender&gt;</c> element.
	/// </summary>
	/// <value> The <c>Gender</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Person's gender."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string Gender
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_GENDER );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_GENDER, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Gender&gt;</c> element.
	/// </summary>
	/// <param name="val">A Gender object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Person's gender."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetGender( Gender val )
	{
		SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_GENDER, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BirthDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>BirthDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The person's date of birth."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public DateTime? BirthDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_BIRTHDATE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_BIRTHDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title1&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title1</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string Title1
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_TITLE1 );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_TITLE1, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Title1&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetTitle1( YesNoUnknown val )
	{
		SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_TITLE1, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ELL&gt;</c> element.
	/// </summary>
	/// <value> The <c>ELL</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public string ELL
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_ELL );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_ELL, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ELL&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public void SetELL( YesNoUnknown val )
	{
		SetField( AssessmentDTD.ASSESSMENTSTUDENTSNAPSHOT_ELL, val );
	}

}}
