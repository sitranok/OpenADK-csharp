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

/// <summary>The schedule-related information for a section repeating for each term in which the session is scheduled</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class ScheduleInfo : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ScheduleInfo
	/// </summary>
	public ScheduleInfo() : base ( StudentDTD.SCHEDULEINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="termInfoRefId">The schedule-related information for a section repeating for each term in which the section is scheduled. The TermInfoRefId attribute value should repeat as necessary to show the appropriate relationship between meeting times, teachers and rooms.</param>
	///
	public ScheduleInfo( string termInfoRefId ) : base( StudentDTD.SCHEDULEINFO )
	{
		this.TermInfoRefId = termInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScheduleInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SCHEDULEINFO_TERMINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>TermInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>TermInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The schedule-related information for a section repeating for each term in which the section is scheduled. The TermInfoRefId attribute value should repeat as necessary to show the appropriate relationship between meeting times, teachers and rooms."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string TermInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHEDULEINFO_TERMINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHEDULEINFO_TERMINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TeacherList&gt;</c> element.
	/// </summary>
	/// <value> A TeacherList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The teacher(s) who teach this section"</para>
	/// <para>To remove the <c>TeacherList</c>, set <c>TeacherList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public TeacherList TeacherList
	{
		get
		{
			return (TeacherList)GetChild( StudentDTD.SCHEDULEINFO_TEACHERLIST);
		}
		set
		{
			RemoveChild( StudentDTD.SCHEDULEINFO_TEACHERLIST);
			if( value != null)
			{
				AddChild( StudentDTD.SCHEDULEINFO_TEACHERLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SectionRoomList&gt;</c> element.
	/// </summary>
	/// <value> A SectionRoomList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The ID (GUID) of the room in which this section is taught"</para>
	/// <para>To remove the <c>SectionRoomList</c>, set <c>SectionRoomList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SectionRoomList SectionRoomList
	{
		get
		{
			return (SectionRoomList)GetChild( StudentDTD.SCHEDULEINFO_SECTIONROOMLIST);
		}
		set
		{
			RemoveChild( StudentDTD.SCHEDULEINFO_SECTIONROOMLIST);
			if( value != null)
			{
				AddChild( StudentDTD.SCHEDULEINFO_SECTIONROOMLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MeetingTimeList&gt;</c> element.
	/// </summary>
	/// <value> A MeetingTimeList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The time(s) this section meets"</para>
	/// <para>To remove the <c>MeetingTimeList</c>, set <c>MeetingTimeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public MeetingTimeList MeetingTimeList
	{
		get
		{
			return (MeetingTimeList)GetChild( StudentDTD.SCHEDULEINFO_MEETINGTIMELIST);
		}
		set
		{
			RemoveChild( StudentDTD.SCHEDULEINFO_MEETINGTIMELIST);
			if( value != null)
			{
				AddChild( StudentDTD.SCHEDULEINFO_MEETINGTIMELIST, value );
			}
		}
	}

}}
