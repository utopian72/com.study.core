/*
jQWidgets v12.0.4 (2021-Apr)
Copyright (c) 2011-2021 jQWidgets.
License: https://jqwidgets.com/license/
*/
/* eslint-disable */

(function(a){a.jqx.jqxWidget("jqxTextArea","",{});a.extend(a.jqx._jqxTextArea.prototype,{defineInstance:function(){var c=this;var b={disabled:false,filter:c._filter,sort:c._sort,highlight:c._highlight,dropDownWidth:null,renderer:c._renderer,opened:false,$popup:document.createElement("ul"),source:[],roundedCorners:true,searchMode:"default",placeHolder:"",width:null,height:null,rtl:false,displayMember:"",valueMember:"",popupZIndex:1000,items:8,minLength:1,maxLength:null,scrollBarSize:a.jqx.utilities.scrollBarSize,query:"",hint:true,changeType:null,events:["change","select","open","close"]};if(this===a.jqx._jqxTextArea.prototype){return b}a.extend(true,c,b);return b},createInstance:function(){var b=this;b._textareaWidthFix=0;if(a.jqx.browser.chrome){b._textareaWidthFix=6}else{if(a.jqx.browser.msie){b._textareaWidthFix=3}}if(document.body.contains(b.element)===false){b._notInDOM=true}b._popupHelper=a(b.$popup);b.render();b.isInitialized=true},render:function(){var f=this;if(f.isInitialized===true){f.refresh();return}if(a.jqx.utilities.scrollBarSize!==15){f.scrollBarSize=a.jqx.utilities.scrollBarSize}var j=document.createElement("div");j.style.overflow="hidden";j.style.width="100%";j.style.height="100%";j.style.backgroundColor="transparent";j.style["-webkit-appearance"]="none";j.style.outline="none";j.style.align="left";j.style.border="0px";j.style.padding="0px";j.style.margin="0px";j.style.left="0px";j.style.top="0px";j.style.valign="top";j.style.position="relative";var b=document.createElement("div");b.style.align="left";b.style.valign="top";b.style.left="0px";b.style.top="0px";b.style.position="absolute";f._baseHost=f.host;a.jqx.utilities.resize(f._baseHost,function(){if(f._notInDOM){f._notInDOM=false;if(f.element.nodeName.toLowerCase()==="textarea"){f.isInitialized=false;f.render()}return}f._ttimer=setTimeout(function(){f.textarea.style.width="";f._arrange()},100)},false,true);this.input=this.element;if(f.element.tagName.toLowerCase()==="div"){f.element.appendChild(j);var d=document.createElement("textarea");d.className=f.toThemeProperty("jqx-text-area-element");f.textarea=d;j.appendChild(d);j.appendChild(b);f.wrapper=f.element}else{if(f.element.tagName.toLowerCase()==="textarea"){if(f._notInDOM){return}f.textarea=f.element;var c=document.createElement("div");f.element.parentNode.insertBefore(c,f.element);c.appendChild(j);j.appendChild(f.element);j.appendChild(b);var e=f.host.data();f.host=a(c);f.host.data(e);c.style.cssText=f.element.style.cssText;f.element.style.cssText="";f.element.className=f.toThemeProperty("jqx-text-area-element");f.wrapper=c;c.setAttribute("id",f.element.id);f.element=c;f.textarea.setAttribute("id",f.element.id+"TextArea")}}var i=f.host;f._addClasses();if(!i.jqxButton){throw new Error("jqxTextArea: Missing reference to jqxbuttons.js.")}if(!i.jqxScrollBar){throw new Error("jqxTextArea: Missing reference to jqxscrollbar.js.")}if(null===f.width&&f.element.style&&null!==f.element.style.width){f.width=f.element.style.width}if(null===f.height&&f.element.style&&null!==f.element.style.height){f.height=f.element.style.height}f._setSize();f.vScrollBar=a(b);f.vScrollBar.jqxScrollBar({vertical:true,width:15,height:"100%",max:f.height,theme:f.theme});if(a.trim(f.textarea.value)===""){f.textarea.value=""}if(f.maxLength!==null){f.textarea.setAttribute("maxlength",f.maxLength)}if((f.source instanceof Array&&f.source.length)||f.source._source||a.isFunction(f.source)){f._oldsource=f.source;f._updateSource();f._addPopupClasses();a.jqx.aria(f,"aria-haspopup",true)}if(f.isMaterialized()){var h=a("<label></label");h[0].innerHTML=this.placeHolder;h.addClass(f.toThemeProperty("jqx-input-label"));var g=a("<span></span>");g.addClass(f.toThemeProperty("jqx-input-bar"));h.insertAfter(this.textarea);g.insertAfter(this.textarea);g.css("top",this.host.height());this.bar=g;this.label=h;var f=this;if(f.template){f.bar.addClass(f.toThemeProperty("jqx-"+f.template));f.label.addClass(f.toThemeProperty("jqx-"+f.template))}}f._arrange();f._refreshPlaceHolder();f._addHandlers()},refresh:function(c){if(c!==true){var b=this;b._setSize();b._arrange();b._removeHandlers();b._addHandlers();if(b.opened===true){b.open()}if(b.isMaterialized()){b.bar.css("top",b.host.height())}}},_arrange:function(){var e=this;var d=e.textarea;var c=d.scrollHeight-e._height(d);var b=Math.max(0,c);e.vScrollBar.jqxScrollBar({max:b,value:d.scrollTop});if(c<5){d.style.width=this._toPx(e._width(e.element));e.vScrollBar[0].style.visibility="hidden"}else{d.style.width=this._toPx(e._width(e.element)-e.scrollBarSize-e._textareaWidthFix);e.vScrollBar[0].style.visibility="visible";e._arrangeScrollbars(e.scrollBarSize)}},val:function(e){var d=this,c=d.textarea,f=c.value,b;if(arguments.length===0||(typeof e==="object"&&a.isEmptyObject(e)===true)){if(d.displayMember!==""&&d.valueMember!==""&&d.selectedItem){if(f===""){return""}return d.selectedItem}return f}if(e&&e.label){if(d.selectedItem&&e.label===d.selectedItem.label&&e.value===d.selectedItem.value){return e.label}d.selectedItem={label:e.label,value:e.value};d.element.setAttribute("data-value",e.value);d.element.setAttribute("data-label",e.label);c.value=e.label;b=e.label}else{if(f===e){return e}c.value=e;d.element.setAttribute("data-value",e);d.element.setAttribute("data-label",e);b=e}d._arrange();d._refreshPlaceHolder();d._raiseEvent("0");return b},focus:function(){this.textarea.focus()},selectAll:function(){var b=this.textarea;if(b[0] instanceof HTMLInputElement===false){b=a(this.textarea)[0]}setTimeout(function(){if("selectionStart" in b){b.focus();b.setSelectionRange(0,b.value.length)}else{var c=b.createTextRange();c.collapse(true);c.moveEnd("character",b.value.length);c.moveStart("character",0);c.select()}},10)},_arrangeScrollbars:function(c){var i=this;var e=i._width(i.element);var l=i._height(i.element);var j=i.vScrollBar,k=j[0];var h=k.style.visibility!=="hidden";var g=2;var f=2;j.jqxScrollBar({width:c,height:parseInt(l,10)-g});k.style.left=(e-c-g-f)+"px";k.style.top="0px";var b=i._width(i.element)-i.vScrollBar.outerWidth();if(i.rtl){k.style.left="0px";var d=h?(parseInt(c,10)+3)+"px":0;i.textarea.style.paddingLeft=i._toPx(d);i.textarea.style.width=i._toPx(b-4)}else{if(j.css("visibility")!=="hidden"){i.textarea.style.width=this._toPx(b-i._textareaWidthFix)}}j.jqxScrollBar("refresh")},destroy:function(){var b=this;b._popupHelper.remove();b.vScrollBar.jqxScrollBar("destroy");b._removeHandlers();b.host.remove()},propertiesChangedHandler:function(d,b,c){if(c&&c.width&&c.height&&Object.keys(c).length==2){d.element.style.width=d._toPx(d.width);d.element.style.height=d._toPx(d.height);d._arrange()}},propertyChangedHandler:function(b,c,e,d){if(b.isInitialized===undefined||b.isInitialized===false){return}if(b.batchUpdate&&b.batchUpdate.width&&b.batchUpdate.height&&Object.keys(b.batchUpdate).length==2){return}if(d!==e){switch(c){case"theme":b.vScrollBar.jqxScrollBar({theme:b.theme});break;case"width":case"height":b.element.style[c]=b._toPx(d);b._arrange();break;case"source":b._oldsource=d;b._updateSource();break;case"displayMember":case"valueMember":b.source=b._oldsource;b._updateSource();break;case"opened":if(d===true){b.open()}else{b.close()}break;case"maxLength":b.textarea.setAttribute("maxlength",d);break;case"placeHolder":b.textarea.setAttribute("placeholder",d);if(a.jqx.browser.msie&&a.jqx.browser.version<10&&b.textarea.value===e){b.textarea.value=d}break;case"scrollBarSize":b._arrange();break;case"dropDownWidth":b.$popup.style.width=b._toPx(d);break;case"roundedCorners":if(d===true){b.element.className+=" "+b.toThemeProperty("jqx-rc-all");b.$popup.className+=" "+b.toThemeProperty("jqx-rc-all")}else{b.host.removeClass(b.toThemeProperty("jqx-rc-all"));b._popupHelper.removeClass(b.toThemeProperty("jqx-rc-all"))}break;case"disabled":b.vScrollBar.jqxScrollBar({disabled:d});if(d===true){b.element.className+=" "+b.toThemeProperty("jqx-fill-state-disabled");b.textarea.setAttribute("disabled","disabled")}else{b.host.removeClass(b.toThemeProperty("jqx-fill-state-disabled"));b.textarea.removeAttribute("disabled")}a.jqx.aria(b,"aria-disabled",d);break;case"rtl":if(d===true){b.textarea.className+=" "+b.toThemeProperty("jqx-text-area-element-rtl")}else{a(b.textarea).removeClass(b.toThemeProperty("jqx-text-area-element-rtl"))}b._arrange();break;default:b.refresh();break}}},_raiseEvent:function(h,c){var g=this;if(c===undefined){c={owner:null}}var d=g.events[h];c.owner=g;var f=new a.Event(d);f.owner=g;if(h==0){c.type=this.changeType;this.changeType=null}f.args=c;if(f.preventDefault){f.preventDefault()}var e;if(d==="change"||g._baseHost[0].tagName.toLowerCase()==="div"){e=g.host}else{e=g.host}var b=e.trigger(f);return b},_addHandlers:function(){var e=this,f=e.element.id,d=e.host,c=e.textarea;var b=a.jqx.browser.mozilla?"wheel":"mousewheel";e.addHandler(d,b+".jqxTextArea"+f,function(g){e.wheel(g,e)});e.addHandler(d,"mouseenter.jqxTextArea"+f,function(){e.focused=true});e.addHandler(d,"mouseleave.jqxTextArea"+f,function(){e.focused=false});e.addHandler(d,"focus.jqxTextArea"+f,function(){e.focused=true});e.addHandler(d,"blur.jqxTextArea"+f,function(){e.focused=false});e.addHandler(e.wrapper,"scroll.jqxTextArea"+f,function(){if(e.wrapper.scrollTop!==0){e.wrapper.scrollTop=0}if(e.wrapper.scrollLeft!==0){e.wrapper.scrollLeft=0}});e.addHandler(c,"change.jqxTextArea"+f,function(g){if(e.opened){return}g.stopPropagation();g.preventDefault();e._arrange();e._refreshPlaceHolder();e._raiseEvent("0")});e.addHandler(c,"select.jqxTextArea"+f,function(g){g.stopPropagation();g.preventDefault()});e.addHandler(c,"scroll.jqxTextArea"+f,function(){var g=Math.max(0,c.scrollHeight-e._height(c));e.vScrollBar.jqxScrollBar({max:g,value:c.scrollTop})});e.addHandler(c,"focus.jqxTextArea"+f,function(){e.element.className+=" "+e.toThemeProperty("jqx-fill-state-focus");if(a.jqx.browser.msie&&a.jqx.browser.version<10&&c.value===e.placeHolder){c.value=""}});e.addHandler(c,"blur.jqxTextArea"+f,function(){e.host.removeClass(e.toThemeProperty("jqx-fill-state-focus"));if(a.jqx.browser.msie&&a.jqx.browser.version<10){var g=e.textarea.value;if(g===""){e.textarea.value=e.placeHolder}else{if(e.maxLength!==null&&g.length>e.maxLength){e.textarea.value=g.substr(0,e.maxLength)}}}});e.addHandler(c,"keydown.jqxTextArea"+f,function(g){e._suppressKeyPressRepeat=~a.inArray(g.keyCode,[40,38,9,13,27]);e.changeType="keyboard";e._move(g)});e.addHandler(c,"keypress.jqxTextArea"+f,function(g){if(e.maxLength!==null&&a.jqx.browser.msie&&a.jqx.browser.version<10&&c.value.length>e.maxLength){return false}if(e._suppressKeyPressRepeat){return}e._move(g)});e.addHandler(c,"keyup.jqxTextArea"+f,function(g){switch(g.keyCode){case 40:case 38:case 16:case 17:case 18:break;case 9:case 13:if(!e.opened){return}e._select();break;case 27:if(!e.opened){return}e.close();break;default:if(e.timer){clearTimeout(e.timer)}e.timer=setTimeout(function(){e._suggest()},300)}g.preventDefault();e._arrange()});e.addHandler(e.vScrollBar,"valueChanged.jqxTextArea"+f,function(g){c.scrollTop=g.currentValue});e.addHandler(e.$popup,"mousedown.jqxTextArea"+f,function(g){g.stopPropagation();g.preventDefault();e.changeType="mouse";e._select()})},_refreshPlaceHolder:function(){var b=this;if(!b.isMaterialized()||!b.hint){if("placeholder" in this.textarea&&!(a.jqx.browser.msie&&a.jqx.browser.version<9)){b.textarea.setAttribute("placeHolder",b.placeHolder)}else{if(b.textarea.value===""){b.textarea.value=b.placeHolder}}}if(b.hint){if(b.textarea.value!==""){b.element.setAttribute("hint",true)}else{b.element.removeAttribute("hint")}if(b.label){b.label.innerHTML=b.placeHolder}}},_removeHandlers:function(){var d=this,e=d.element.id,c=d.host,b=d.textarea;a.jqx.utilities.resize(d._baseHost,null,true);d.removeHandler(c,"mousewheel.jqxTextArea"+e);d.removeHandler(c,"mouseenter.jqxTextArea"+e);d.removeHandler(c,"mouseleave.jqxTextArea"+e);d.removeHandler(c,"focus.jqxTextArea"+e);d.removeHandler(c,"blur.jqxTextArea"+e);d.removeHandler(d.wrapper,"scroll.jqxTextArea"+e);d.removeHandler(b,"change.jqxTextArea"+e);d.removeHandler(b,"select.jqxTextArea"+e);d.removeHandler(b,"scroll.jqxTextArea"+e);d.removeHandler(b,"focus.jqxTextArea"+e);d.removeHandler(b,"blur.jqxTextArea"+e);d.removeHandler(b,"keydown.jqxTextArea"+e);d.removeHandler(b,"keypress.jqxTextArea"+e);d.removeHandler(b,"keyup.jqxTextArea"+e);d.removeHandler(d.vScrollBar,"valueChanged.jqxTextArea"+e);d.removeHandler(d.$popup,"mousedown.jqxTextArea"+e)},_itemHandler:function(b){a(this._find("jqx-fill-state-pressed",this._popupHelper)).removeClass(this.toThemeProperty("jqx-fill-state-pressed"));b.currentTarget.className+=" "+this.toThemeProperty("jqx-fill-state-pressed")},wheel:function(d,c){var e=0;if(d.originalEvent&&a.jqx.browser.msie&&d.originalEvent.wheelDelta){e=d.originalEvent.wheelDelta/120}if(!d){d=window.event}if(d.wheelDelta){e=d.wheelDelta/120}else{if(d.detail){e=-d.detail/3}else{if(d.originalEvent.wheelDelta){e=d.originalEvent.wheelDelta/120}else{if(d.originalEvent.detail){e=-d.originalEvent.detail/3}else{if(d.originalEvent.deltaY){e=-d.originalEvent.deltaY/3}}}}}if(e){var b=c._handleDelta(e);if(!b){if(d.preventDefault){d.preventDefault()}}if(!b){return b}else{return false}}if(d.preventDefault){d.preventDefault()}d.returnValue=false},_handleDelta:function(f){var c=this,d=c.vScrollBar.jqxScrollBar("getInstance");if(c.focused){var e=d.value;if(f<0){c.scrollDown()}else{c.scrollUp()}var b=d.value;if(e!==b){return false}}return true},scrollDown:function(){var c=this;if(c.vScrollBar.css("visibility")==="hidden"){return false}var d=c.vScrollBar.jqxScrollBar("getInstance");var b=Math.min(d.value+d.largestep,d.max);d.setPosition(b);c._arrange();return true},scrollUp:function(){var c=this;if(c.vScrollBar.css("visibility")==="hidden"){return false}var d=c.vScrollBar.jqxScrollBar("getInstance");var b=Math.max(d.value-d.largestep,d.min);d.setPosition(b);c._arrange();return true},_setSize:function(){var b=this;b.element.style.width=b._toPx(b.width);b.element.style.height=b._toPx(b.height)},_addClasses:function(){var c=this,b="jqx-panel jqx-widget jqx-widget-content jqx-text-area";c.textarea.className+=" "+c.toThemeProperty("jqx-widget jqx-widget-content");if(c.roundedCorners===true){b+=" jqx-rc-all"}if(c.disabled===true){b+=" jqx-fill-state-disabled";c.textarea.setAttribute("disabled","disabled");a.jqx.aria(c,"aria-disabled",true)}else{a.jqx.aria(c,"aria-disabled",false)}if(c.rtl===true){c.textarea.className+=" "+c.toThemeProperty("jqx-text-area-element-rtl")}c.element.className+=" "+c.toThemeProperty(b)},_addPopupClasses:function(){var c=this,b="jqx-popup jqx-input-popup jqx-menu jqx-menu-vertical jqx-menu-dropdown jqx-widget jqx-widget-content";if(a.jqx.browser.msie){b+=" jqx-noshadow"}if(c.roundedCorners){b+=" jqx-rc-all"}c.$popup.className+=" "+c.toThemeProperty(b)},_updateSource:function(){var d=this;var e=function(g){if(g===undefined){return null}if(typeof g==="string"||g instanceof String){return{label:g,value:g}}if(typeof g!=="string"&&g instanceof String===false){var f="";var h="";if(d.displayMember!==""&&d.displayMember!==undefined){if(g[d.displayMember]){f=g[d.displayMember]}}if(d.valueMember!==""&&d.valueMember!==undefined){h=g[d.valueMember]}if(f===""){f=g.label}if(h===""){h=g.value}return{label:f,value:h}}return g};var b=function(h){var f=[];for(var g=0;g<h.length;g++){f[g]=e(h[g])}return f};if(this.source&&this.source._source){this.adapter=this.source;if(this.adapter._source.localdata!=null){this.adapter.unbindBindingUpdate(this.element.id);this.adapter.bindBindingUpdate(this.element.id,function(){d.source=b(d.adapter.records)})}else{var c={};if(this.adapter._options.data){a.extend(d.adapter._options.data,c)}else{if(this.source._source.data){a.extend(c,this.source._source.data)}this.adapter._options.data=c}this.adapter.unbindDownloadComplete(this.element.id);this.adapter.bindDownloadComplete(this.element.id,function(){d.source=b(d.adapter.records)})}this.source.dataBind();return}if(!a.isFunction(this.source)){this.source=b(this.source)}},open:function(){if(a.jqx.isHidden(this.host)){return}var c=a.extend({},this.host.coord(true),{height:this.element.offsetHeight});if(this.$popup.parentNode!==document.body){var e=this.element.id+"_popup";this.$popup.id=e;a.jqx.aria(this,"aria-owns",e);document.body.appendChild(this.$popup)}this.$popup.style.position="absolute";this.$popup.style.zIndex=this.popupZIndex;this.$popup.style.top=this._toPx(c.top+c.height);this.$popup.style.left=this._toPx(c.left);this.$popup.style.display="block";var b=0;var d=this._popupHelper.children();a.each(d,function(){b+=a(this).outerHeight()+1});this.$popup.style.height=this._toPx(b);this.opened=true;this._raiseEvent("2",{popup:this.$popup});a.jqx.aria(this,"aria-expanded",true);return this},close:function(){this.$popup.style.display="none";this.opened=false;this._raiseEvent("3",{popup:this.$popup});a.jqx.aria(this,"aria-expanded",false);return this},_suggest:function(){var c=this,b;c.query=c.textarea.value;if(!c.query||c.query.length<c.minLength){return c.opened?c.close():c}if(a.isFunction(c.source)){b=c.source(c.query,a.proxy(c._load,this))}else{b=c.source}if(b){return c._load(b)}return c},_load:function(b){var c=this;b=a.grep(b,function(d){return c.filter(d)});b=c.sort(b);if(!b.length){if(c.opened){return c.close()}else{return c}}return c._render(b.slice(0,c.items)).open()},_filter:function(c){var b=this;var d=b.query;var e=c;if(c.label!==undefined){e=c.label}else{if(b.displayMember){e=c[b.displayMember]}}switch(b.searchMode){case"none":break;case"contains":return a.jqx.string.contains(e,d);case"equals":return a.jqx.string.equals(e,d);case"equalsignorecase":return a.jqx.string.equalsIgnoreCase(e,d);case"startswith":return a.jqx.string.startsWith(e,d);case"startswithignorecase":return a.jqx.string.startsWithIgnoreCase(e,d);case"endswith":return a.jqx.string.endsWith(e,d);case"endswithignorecase":return a.jqx.string.endsWithIgnoreCase(e,d);default:return a.jqx.string.containsIgnoreCase(e,d)}},_sort:function(b){var g=this,j=[],d=[],f=[];for(var c=0;c<b.length;c++){var e=b[c];var h=e;if(e.label){h=e.label}else{if(g.displayMember){h=e[g.displayMember]}}if(h.toString().toLowerCase().indexOf(g.query.toString().toLowerCase())===0){j.push(e)}else{if(h.toString().indexOf(g.query)>=0){d.push(e)}else{if(h.toString().toLowerCase().indexOf(g.query.toString().toLowerCase())>=0){f.push(e)}}}}return j.concat(d,f)},escape_HTML:function(b){return b.replace(/[&<>"]/g,function(d){var c={"&":"&","<":"<",">":">",'"':'"'};return c[d]||d})},_render:function(f){var e=this,c=e._popupHelper.children();if(c.length>0){for(var d=0;d<c.length;d++){a(c[d]).remove()}}var g=function(n,k){var p=n,m=document.createElement("li"),j=document.createElement("a"),h,o;j.setAttribute("href","#");m.appendChild(j);if(n.value!==undefined&&n.value!==null){if(n.label!==undefined&&n.label!==null){h=n.label;o=e.escape_HTML(n.value)}else{h=n.value;o=e.escape_HTML(n.value)}}else{if(n.label!==undefined&&n.label!==null){h=n.label;o=n.label}else{if(e.displayMember!==undefined&&e.displayMember!==""){h=n[e.displayMember];o=n[e.valueMember]}else{h=n;o=n}}}m.setAttribute("data-value",o);m.setAttribute("data-name",h);if(n.label){p=n.label}else{if(e.displayMember){p=n[e.displayMember]}}j.innerHTML=e.highlight(p);var l="";if(e.rtl){l=" jqx-rtl"}if(k===0){l+=" jqx-fill-state-pressed"}m.className=e.toThemeProperty("jqx-item jqx-menu-item jqx-rc-all"+l);e.$popup.appendChild(m);e.addHandler(m,"mouseenter",function(i){e._itemHandler(i)})};var b=function(j){for(var h=0;h<j.length;h++){g(j[h],h)}};b(f);if(!this.dropDownWidth){this.$popup.style.width=e._toPx(e.element.offsetWidth-6)}else{this.$popup.style.width=e._toPx(e.dropDownWidth)}return this},_highlight:function(c){var d=this.query;d=d.replace(/[\-\[\]\/\{\}\(\)\*\+\?\.\\\^\$\|]/g,"\\$&");var b=new RegExp("("+d+")","ig");return c.replace(b,function(e,f){return"<b>"+f+"</b>"})},_select:function(){var c=this._find("jqx-fill-state-pressed",this._popupHelper);var d=c.getAttribute("data-value");var b=c.getAttribute("data-name");this.textarea.value=this.renderer(b,this.textarea.value);this.selectedItem={label:b,value:d};this.element.setAttribute("data-value",d);this.element.setAttribute("data-label",b);this._raiseEvent("1",{item:{label:b,value:d}});this._arrange();this.textarea.scrollTop=this.textarea.scrollHeight;this._raiseEvent("0");return this.close()},_renderer:function(b){return b},_move:function(c){var b=this;if(!b.opened){return}switch(c.keyCode){case 9:case 13:case 27:c.preventDefault();break;case 38:if(!c.shiftKey){c.preventDefault();b._prev()}break;case 40:if(!c.shiftKey){c.preventDefault();b._next()}break}c.stopPropagation()},_next:function(){var c=this._find("jqx-fill-state-pressed",this._popupHelper),b=c.nextSibling;a(c).removeClass(this.toThemeProperty("jqx-fill-state-pressed"));if(!b){b=this.$popup.firstChild}b.className+=" "+this.toThemeProperty("jqx-fill-state-pressed")},_prev:function(){var c=this._find("jqx-fill-state-pressed",this._popupHelper),b=c.previousSibling;a(c).removeClass(this.toThemeProperty("jqx-fill-state-pressed"));if(!b){b=this.$popup.lastChild}b.className+=" "+this.toThemeProperty("jqx-fill-state-pressed")},_toPx:function(b){if(typeof b==="number"){return b+"px"}else{return b}},_find:function(e,b){var d=b.children();for(var c=0;c<d.length;c++){var f=d[c];if(f.className.indexOf(e)!==-1){return f}}},_width:function(e){var b=a(e),g=b.css("border-left-width"),c=b.css("border-right-width"),d=parseInt(b.css("padding-left"),10),h=parseInt(b.css("padding-right"),10);if(g.indexOf("px")===-1){g=1}else{g=parseInt(g,10)}if(c.indexOf("px")===-1){c=1}else{c=parseInt(c,10)}var f=e.offsetWidth-(g+c+d+h);if(f>0){return f}else{return""}},_height:function(e){var c=a(e),h=c.css("border-top-width"),d=c.css("border-bottom-width"),f=parseInt(c.css("padding-top"),10),g=parseInt(c.css("padding-bottom"),10);if(h.indexOf("px")===-1){h=1}else{h=parseInt(h,10)}if(d.indexOf("px")===-1){d=1}else{d=parseInt(d,10)}var b=e.offsetHeight-(h+d+f+g);if(b>0){return b}else{return""}}})})(jqxBaseFramework);

