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

/// <summary>An entry for each unique bell period for the bell schedule</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class BellPeriod : SifElement
{
	/// <summary>
	/// Creates an instance of a BellPeriod
	/// </summary>
	public BellPeriod() : base ( StudentDTD.BELLPERIOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="timetableDayIdentifier">The unique identifier for the timetable day used for the bell period (from a TimetableDayList).</param>
	///<param name="timetablePeriodIdentifier">The unique identifier for the timetable period used for the bell period (from a TimetablePeriodList).</param>
	///<param name="startTime">The starting time for the bell period.</param>
	///<param name="endTime">The ending time for the bell period.</param>
	///<param name="regularSchoolPeriod">Indicates if the bell period is part of the regular school day (i.e. is not a before or after school or break period).</param>
	///<param name="instructionalMinutes">The number of minutes to be counted for instruction for the bell period.</param>
	///<param name="useInAttendanceCalculations">Indicates if the bell period should be included in attendance calculations.</param>
	///
	public BellPeriod( string timetableDayIdentifier, string timetablePeriodIdentifier, DateTime? startTime, DateTime? endTime, YesNo regularSchoolPeriod, int? instructionalMinutes, YesNo useInAttendanceCalculations ) : base( StudentDTD.BELLPERIOD )
	{
		this.TimetableDayIdentifier = timetableDayIdentifier;
		this.TimetablePeriodIdentifier = timetablePeriodIdentifier;
		this.StartTime = startTime;
		this.EndTime = endTime;
		this.SetRegularSchoolPeriod( regularSchoolPeriod );
		this.InstructionalMinutes = instructionalMinutes;
		this.SetUseInAttendanceCalculations( useInAttendanceCalculations );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected BellPeriod( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.BELLPERIOD_TIMETABLEDAYIDENTIFIER, StudentDTD.BELLPERIOD_TIMETABLEPERIODIDENTIFIER, StudentDTD.BELLPERIOD_STARTTIME, StudentDTD.BELLPERIOD_ENDTIME, StudentDTD.BELLPERIOD_REGULARSCHOOLPERIOD, StudentDTD.BELLPERIOD_INSTRUCTIONALMINUTES, StudentDTD.BELLPERIOD_USEINATTENDANCECALCULATIONS }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimetableDayIdentifier&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimetableDayIdentifier</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The unique identifier for the timetable day used for the bell period (from a TimetableDayList)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string TimetableDayIdentifier
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.BELLPERIOD_TIMETABLEDAYIDENTIFIER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLPERIOD_TIMETABLEDAYIDENTIFIER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TimetablePeriodIdentifier&gt;</c> element.
	/// </summary>
	/// <value> The <c>TimetablePeriodIdentifier</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The unique identifier for the timetable period used for the bell period (from a TimetablePeriodList)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string TimetablePeriodIdentifier
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.BELLPERIOD_TIMETABLEPERIODIDENTIFIER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLPERIOD_TIMETABLEPERIODIDENTIFIER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The starting time for the bell period."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? StartTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.BELLPERIOD_STARTTIME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLPERIOD_STARTTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The ending time for the bell period."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? EndTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.BELLPERIOD_ENDTIME ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLPERIOD_ENDTIME, new SifTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RegularSchoolPeriod&gt;</c> element.
	/// </summary>
	/// <value> The <c>RegularSchoolPeriod</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if the bell period is part of the regular school day (i.e. is not a before or after school or break period)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string RegularSchoolPeriod
	{
		get
		{ 
			return GetFieldValue( StudentDTD.BELLPERIOD_REGULARSCHOOLPERIOD );
		}
		set
		{
			SetField( StudentDTD.BELLPERIOD_REGULARSCHOOLPERIOD, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;RegularSchoolPeriod&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if the bell period is part of the regular school day (i.e. is not a before or after school or break period)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetRegularSchoolPeriod( YesNo val )
	{
		SetField( StudentDTD.BELLPERIOD_REGULARSCHOOLPERIOD, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InstructionalMinutes&gt;</c> element.
	/// </summary>
	/// <value> The <c>InstructionalMinutes</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The number of minutes to be counted for instruction for the bell period."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public int? InstructionalMinutes
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.BELLPERIOD_INSTRUCTIONALMINUTES ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.BELLPERIOD_INSTRUCTIONALMINUTES, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;UseInAttendanceCalculations&gt;</c> element.
	/// </summary>
	/// <value> The <c>UseInAttendanceCalculations</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if the bell period should be included in attendance calculations."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string UseInAttendanceCalculations
	{
		get
		{ 
			return GetFieldValue( StudentDTD.BELLPERIOD_USEINATTENDANCECALCULATIONS );
		}
		set
		{
			SetField( StudentDTD.BELLPERIOD_USEINATTENDANCECALCULATIONS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;UseInAttendanceCalculations&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if the bell period should be included in attendance calculations."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetUseInAttendanceCalculations( YesNo val )
	{
		SetField( StudentDTD.BELLPERIOD_USEINATTENDANCECALCULATIONS, val );
	}

}}
