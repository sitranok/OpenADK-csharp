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

/// <summary>The timetable days for this school year bell schedule. This essentially provides a list of the time day identifiers that are used in the BellPeriod definitions below with some additional properties for each. The identifiers defined here may be referenced by other objects / elements like MeetingTime.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class TimetableDayList : SifKeyedList<TimetableDay>
{
	/// <summary>
	/// Creates an instance of a TimetableDayList
	/// </summary>
	public TimetableDayList() : base ( StudentDTD.TIMETABLEDAYLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="timetableDay">An entry for each unique timetable day</param>
	///
	public TimetableDayList( TimetableDay timetableDay ) : base( StudentDTD.TIMETABLEDAYLIST )
	{
		this.SafeAddChild( StudentDTD.TIMETABLEDAYLIST_TIMETABLEDAY, timetableDay );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TimetableDayList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.TIMETABLEDAYLIST_TIMETABLEDAY }; }
	}

	///<summary>Adds the value of the <c>&lt;TimetableDay&gt;</c> element.</summary>
	/// <param name="Identifier">The unique identifier for the timetable day for this school calendar.</param>
	///<remarks>
	/// <para>This form of <c>setTimetableDay</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddTimetableDay</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddTimetableDay( string Identifier ) {
		AddChild( StudentDTD.TIMETABLEDAYLIST_TIMETABLEDAY, new TimetableDay( Identifier ) );
	}

}}
