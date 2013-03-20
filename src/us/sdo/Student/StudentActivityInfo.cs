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

namespace OpenADK.Library.us.Student{

/// <summary>Co-curricular or extra-curricular activities (e.g., student organizations, intramural and interscholastic athletes, publications, band, orchestra, and service activities) in which students may participate.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentActivityInfo : SifElement
{
	/// <summary>
	/// Creates an instance of a StudentActivityInfo
	/// </summary>
	public StudentActivityInfo() : base ( StudentDTD.STUDENTACTIVITYINFO ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentActivityInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the co-curricular or extra-curricular activity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFO_TITLE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFO_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The description of the co-curricular or extra-curricular activity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentActivity&gt;</c> element.
	/// </summary>
	/// <value> A StudentActivityType </value>
	/// <remarks>
	/// <para>To remove the <c>StudentActivityType</c>, set <c>StudentActivity</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public StudentActivityType StudentActivity
	{
		get
		{
			return (StudentActivityType)GetChild( StudentDTD.STUDENTACTIVITYINFO_STUDENTACTIVITY);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTACTIVITYINFO_STUDENTACTIVITY);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTACTIVITYINFO_STUDENTACTIVITY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentActivityLevel&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentActivityLevel</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A description of the separation of level in the activity. "</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StudentActivityLevel
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFO_STUDENTACTIVITYLEVEL ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFO_STUDENTACTIVITYLEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Collection of grade levels applicable to this co-curricular or extra-curricular activity."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( StudentDTD.STUDENTACTIVITYINFO_GRADELEVELS);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTACTIVITYINFO_GRADELEVELS);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTACTIVITYINFO_GRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CurricularStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>CurricularStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An indication of the degree to which an activity is related to a student's curriculum."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string CurricularStatus
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTACTIVITYINFO_CURRICULARSTATUS ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTACTIVITYINFO_CURRICULARSTATUS, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Location&gt;</c> element.</summary>
	/// <param name="Type">Values: Classroom, School, District, Campus, IntermediateUnit, StateEducationAgency</param>
	///<remarks>
	/// <para>This form of <c>setLocation</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Location</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetLocation( string Type ) {
		RemoveChild( StudentDTD.STUDENTACTIVITYINFO_LOCATION);
		AddChild( StudentDTD.STUDENTACTIVITYINFO_LOCATION, new StudentActivityInfoLocation( Type ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Location&gt;</c> element.
	/// </summary>
	/// <value> A StudentActivityInfoLocation </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Location where the activity takes place."</para>
	/// <para>To remove the <c>StudentActivityInfoLocation</c>, set <c>Location</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public StudentActivityInfoLocation Location
	{
		get
		{
			return (StudentActivityInfoLocation)GetChild( StudentDTD.STUDENTACTIVITYINFO_LOCATION);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTACTIVITYINFO_LOCATION);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTACTIVITYINFO_LOCATION, value );
			}
		}
	}

}}
