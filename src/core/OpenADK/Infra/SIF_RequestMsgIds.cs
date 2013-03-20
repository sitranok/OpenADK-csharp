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

/// <summary>A SIF_RequestMsgIds</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class SIF_RequestMsgIds : SifKeyedList<SIF_RequestMsgId>
{
	/// <summary>
	/// Creates an instance of a SIF_RequestMsgIds
	/// </summary>
	public SIF_RequestMsgIds() : base ( InfraDTD.SIF_REQUESTMSGIDS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifRequestMsgId">A SIF_RequestMsgId</param>
	///
	public SIF_RequestMsgIds( SIF_RequestMsgId sifRequestMsgId ) : base( InfraDTD.SIF_REQUESTMSGIDS )
	{
		this.SafeAddChild( InfraDTD.SIF_REQUESTMSGIDS_SIF_REQUESTMSGID, sifRequestMsgId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_RequestMsgIds( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_REQUESTMSGIDS_SIF_REQUESTMSGID }; }
	}

	///<summary>Adds the value of the <c>&lt;SIF_RequestMsgId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;SIF_RequestMsgId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSIF_RequestMsgId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_RequestMsgId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void AddSIF_RequestMsgId( string Value ) {
		AddChild( InfraDTD.SIF_REQUESTMSGIDS_SIF_REQUESTMSGID, new SIF_RequestMsgId( Value ) );
	}

}}
