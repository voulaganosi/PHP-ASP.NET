    o":InteractionLifeLine {
	parentConnectorHeaderLength=40;
	_fillColor=(
		@gradientStyle=1;, 
		@transparency=0;, 
		@type=1;, 
		@color1=(
			122, 
			207, 
			245, 
			255
		);
	);
	background=(
		122, 
		207, 
		245, 
		255
	);
	width=70;
	_captionUIModel=(
		@x=0;, 
		@y=0;, 
		@width=70;, 
		@height=15;, 
		@side=1;, 
		@visible=T;, 
		@internalWidth=-2147483648;, 
		@internalHeight=-2147483648;
	);
	_elementFont=(
		@name="Dialog";, 
		@color=(
			0, 
			0, 
			0, 
			255
		);, 
		@size=11;, 
		@style=0;
	);
	modelElementNameAlignment=1;
	metaModelElement=<Ld0HOoqGAqAmXhGl:99fXOoqGAqAmXiGV>;
	foreground=(
		0, 
		0, 
		0, 
		255
	);
	connectToPoint=T;
	y=40;
	overrideAppearanceWithStereotypeIcon=T;
	x=957;
	_lineModel=(
		@cap=0;, 
		@transparency=0;, 
		@weight=1.0;, 
		@color=(
			0, 
			0, 
			0, 
			255
		);, 
		@hasStroke=T;
	);
	height=484;
	parentFrame=<Ld0HOoqGAqAmXhGl>;
	parentConnectorLineLength=10;
}                          #  #                         �Y�E-  -�4 uQ0POoqGAqAmXiH4MessageKgwnOoqGAqAmXh0Cset()uQ0POoqGAqAmXiH4:"set()":Message {
	toActivation=<Ld0HOoqGAqAmXhGl:99fXOoqGAqAmXiGV$WI0POoqGAqAmXiH_>;
	_modelEditable=T;
	fromActivation=<Ld0HOoqGAqAmXhGl:CPQPOoqGAqAmXiHO$g9YPOoqGAqAmXiHo>;
	_masterViewId="UI0POoqGAqAmXiH7";
	pmAuthor="user";
	pmCreateDateTime="1448963256477";
	_modelViews=(
		{UI0POoqGAqAmXiH8:"View":ModelView {
			container=<qd0HOoqGAqAmXhGh>;
			view="UI0POoqGAqAmXiH7";
		}}
	);
	sequenceNumber="6.1.1";
	from={uQ0POoqGAqAmXiH5:NULL:MessageEnd {
		pmAuthor="user";
		pmCreateDateTime="1448963256477";
		_modelViews=NULL;
		Direction=0;
		_modelEditable=T;
		EndModelElement=<Ld0HOoqGAqAmXhGl:CPQPOoqGAqAmXiHO>;
	}};
	to={uQ0POoqGAqAmXiH6:NULL:MessageEnd {
		pmAuthor="user";
		pmCreateDateTime="1448963256477";
		_modelViews=NULL;
		Direction=1;
		_modelEditable=T;
		EndModelElement=<Ld0HOoqGAqAmXhGl:99fXOoqGAqAmXiGV>;
	}};
	pmLastModified="1448963755958";
}userV]l�V]n�edHandler Then
                                AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                                addedHandler = True
                            End If
                        End SyncLock
                    End If
#End If
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Lab9.My.MySettings
            Get
                Return Global.Lab9.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
