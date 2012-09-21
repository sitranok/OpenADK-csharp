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

namespace OpenADK.Library.us.Profdev{

/// <summary>This object contains information about courses and activities taken by employees.  SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class EmployeeCredit : SifDataObject
{
	/// <summary>
	/// Creates an instance of an EmployeeCredit
	/// </summary>
	public EmployeeCredit() : base( Adk.SifVersion, ProfdevDTD.EMPLOYEECREDIT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">This is the GUID for this object.</param>
	///<param name="employeePersonalRefId">References EmployeePersonal object.</param>
	///<param name="professionalDevelopmentActivitiesRefId">References the ProfDevActivities object</param>
	///<param name="endDate">Date in which the course or activity was completed and awarded credit.</param>
	///<param name="earned">The number of units earned</param>
	///
	public EmployeeCredit( string refId, string employeePersonalRefId, string professionalDevelopmentActivitiesRefId, DateTime? endDate, Earned earned ) : base( Adk.SifVersion, ProfdevDTD.EMPLOYEECREDIT )
	{
		this.RefId = refId;
		this.EmployeePersonalRefId = employeePersonalRefId;
		this.ProfessionalDevelopmentActivitiesRefId = professionalDevelopmentActivitiesRefId;
		this.EndDate = endDate;
		this.Earned = earned;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EmployeeCredit( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { ProfdevDTD.EMPLOYEECREDIT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "This is the GUID for this object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.EMPLOYEECREDIT_REFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.EMPLOYEECREDIT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>EmployeePersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>EmployeePersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "References EmployeePersonal object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string EmployeePersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.EMPLOYEECREDIT_EMPLOYEEPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.EMPLOYEECREDIT_EMPLOYEEPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ProfessionalDevelopmentActivitiesRefId</c> attribute.
	/// </summary>
	/// <value> The <c>ProfessionalDevelopmentActivitiesRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "References the ProfDevActivities object"</para>
	/// <para>This attribute is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering attributes of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;ProfessionalDevelopmentActivitiesRefId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string ProfessionalDevelopmentActivitiesRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( ProfdevDTD.EMPLOYEECREDIT_PROFESSIONALDEVELOPMENTACTIVITIESREFID ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.EMPLOYEECREDIT_PROFESSIONALDEVELOPMENTACTIVITIESREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date in which the course or activity was completed and awarded credit."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? EndDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( ProfdevDTD.EMPLOYEECREDIT_ENDDATE ) ;
		}
		set
		{
			SetFieldValue( ProfdevDTD.EMPLOYEECREDIT_ENDDATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Earned&gt;</c> element.</summary>
	/// <param name="Type">The unit description</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Earned&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setEarned</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Earned</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetEarned( EarnedType Type, string Value ) {
		RemoveChild( ProfdevDTD.EMPLOYEECREDIT_EARNED);
		AddChild( ProfdevDTD.EMPLOYEECREDIT_EARNED, new Earned( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Earned&gt;</c> element.
	/// </summary>
	/// <value> An Earned </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The number of units earned"</para>
	/// <para>To remove the <c>Earned</c>, set <c>Earned</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public Earned Earned
	{
		get
		{
			return (Earned)GetChild( ProfdevDTD.EMPLOYEECREDIT_EARNED);
		}
		set
		{
			RemoveChild( ProfdevDTD.EMPLOYEECREDIT_EARNED);
			if( value != null)
			{
				AddChild( ProfdevDTD.EMPLOYEECREDIT_EARNED, value );
			}
		}
	}

}}