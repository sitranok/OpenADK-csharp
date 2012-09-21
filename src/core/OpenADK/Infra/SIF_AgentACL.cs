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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_AgentACL</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_AgentACL : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SIF_AgentACL
	/// </summary>
	public SIF_AgentACL() : base( Adk.SifVersion, InfraDTD.SIF_AGENTACL ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_AgentACL( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Sets the value of the <c>&lt;SIF_ProvideAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_ProvideAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_ProvideAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_ProvideAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PROVIDEACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_PROVIDEACCESS, new SIF_ProvideAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ProvideAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_ProvideAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_ProvideAccess</c>, set <c>SIF_ProvideAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_ProvideAccess SIF_ProvideAccess
	{
		get
		{
			return (SIF_ProvideAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_PROVIDEACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PROVIDEACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_PROVIDEACCESS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_SubscribeAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_SubscribeAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_SubscribeAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_SubscribeAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_SUBSCRIBEACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_SUBSCRIBEACCESS, new SIF_SubscribeAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_SubscribeAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_SubscribeAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_SubscribeAccess</c>, set <c>SIF_SubscribeAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_SubscribeAccess SIF_SubscribeAccess
	{
		get
		{
			return (SIF_SubscribeAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_SUBSCRIBEACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_SUBSCRIBEACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_SUBSCRIBEACCESS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_PublishAddAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_PublishAddAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_PublishAddAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_PublishAddAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHADDACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHADDACCESS, new SIF_PublishAddAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_PublishAddAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_PublishAddAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_PublishAddAccess</c>, set <c>SIF_PublishAddAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_PublishAddAccess SIF_PublishAddAccess
	{
		get
		{
			return (SIF_PublishAddAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHADDACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHADDACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHADDACCESS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_PublishChangeAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_PublishChangeAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_PublishChangeAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_PublishChangeAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHCHANGEACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHCHANGEACCESS, new SIF_PublishChangeAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_PublishChangeAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_PublishChangeAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_PublishChangeAccess</c>, set <c>SIF_PublishChangeAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_PublishChangeAccess SIF_PublishChangeAccess
	{
		get
		{
			return (SIF_PublishChangeAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHCHANGEACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHCHANGEACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHCHANGEACCESS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_PublishDeleteAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_PublishDeleteAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_PublishDeleteAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_PublishDeleteAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHDELETEACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHDELETEACCESS, new SIF_PublishDeleteAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_PublishDeleteAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_PublishDeleteAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_PublishDeleteAccess</c>, set <c>SIF_PublishDeleteAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_PublishDeleteAccess SIF_PublishDeleteAccess
	{
		get
		{
			return (SIF_PublishDeleteAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHDELETEACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHDELETEACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_PUBLISHDELETEACCESS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_RequestAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_RequestAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_RequestAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_RequestAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_REQUESTACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_REQUESTACCESS, new SIF_RequestAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_RequestAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_RequestAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_RequestAccess</c>, set <c>SIF_RequestAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_RequestAccess SIF_RequestAccess
	{
		get
		{
			return (SIF_RequestAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_REQUESTACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_REQUESTACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_REQUESTACCESS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;SIF_RespondAccess&gt;</c> element.</summary>
	/// <param name="SifObject">A SIF_Object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_RespondAccess</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SIF_RespondAccess</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_RespondAccess( SIF_Object SifObject ) {
		RemoveChild( InfraDTD.SIF_AGENTACL_SIF_RESPONDACCESS);
		AddChild( InfraDTD.SIF_AGENTACL_SIF_RESPONDACCESS, new SIF_RespondAccess( SifObject ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_RespondAccess&gt;</c> element.
	/// </summary>
	/// <value> A SIF_RespondAccess </value>
	/// <remarks>
	/// <para>To remove the <c>SIF_RespondAccess</c>, set <c>SIF_RespondAccess</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SIF_RespondAccess SIF_RespondAccess
	{
		get
		{
			return (SIF_RespondAccess)GetChild( InfraDTD.SIF_AGENTACL_SIF_RESPONDACCESS);
		}
		set
		{
			RemoveChild( InfraDTD.SIF_AGENTACL_SIF_RESPONDACCESS);
			if( value != null)
			{
				AddChild( InfraDTD.SIF_AGENTACL_SIF_RESPONDACCESS, value );
			}
		}
	}

}}