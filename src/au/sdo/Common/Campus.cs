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

namespace OpenADK.Library.au.Common{

/// <summary>A Campus</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Campus : SifElement
{
	/// <summary>
	/// Creates an instance of a Campus
	/// </summary>
	public Campus() : base ( CommonDTD.CAMPUS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="schoolCampusId">Campus ID  - Needs to be considered as part of School. Different Campus' have different addresses</param>
	///<param name="adminStatus">Is this Campus the Admin Campus?</param>
	///
	public Campus( string schoolCampusId, AUCodeSetsYesOrNoCategoryType adminStatus ) : base( CommonDTD.CAMPUS )
	{
		this.SchoolCampusId = schoolCampusId;
		this.SetAdminStatus( adminStatus );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Campus( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.CAMPUS_SCHOOLCAMPUSID, CommonDTD.CAMPUS_ADMINSTATUS }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolCampusId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolCampusId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Campus ID  - Needs to be considered as part of School. Different Campus' have different addresses"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolCampusId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CAMPUS_SCHOOLCAMPUSID ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CAMPUS_SCHOOLCAMPUSID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentSchoolId&gt;</c> element.
	/// </summary>
	/// <value> The <c>ParentSchoolId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Parent School Id needs to be supplied if this Campus is not the Admin Campus. This number should be the state-assigned identifier for this school or the locally-assigned identifier for this school."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ParentSchoolId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.CAMPUS_PARENTSCHOOLID ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.CAMPUS_PARENTSCHOOLID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CampusType&gt;</c> element.
	/// </summary>
	/// <value> The <c>CampusType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Type of Campus"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string CampusType
	{
		get
		{ 
			return GetFieldValue( CommonDTD.CAMPUS_CAMPUSTYPE );
		}
		set
		{
			SetField( CommonDTD.CAMPUS_CAMPUSTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CampusType&gt;</c> element.
	/// </summary>
	/// <param name="val">A CampusAUSchoolLevelType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Type of Campus"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetCampusType( CampusAUSchoolLevelType val )
	{
		SetField( CommonDTD.CAMPUS_CAMPUSTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AdminStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>AdminStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this Campus the Admin Campus?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AdminStatus
	{
		get
		{ 
			return GetFieldValue( CommonDTD.CAMPUS_ADMINSTATUS );
		}
		set
		{
			SetField( CommonDTD.CAMPUS_ADMINSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AdminStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this Campus the Admin Campus?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAdminStatus( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( CommonDTD.CAMPUS_ADMINSTATUS, val );
	}

}}
