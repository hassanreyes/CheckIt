$(document).ready(function () {

    var lastSentToken = -1;
    var removeFlag = false;

    function OnFocusStyle() {
        //$(this).toggleClass("editableTextField");//.select();
        $(this).removeClass("textField").addClass("editableTextField").select();
    }
    function OnFocusOutStyle() {
        //$(this).toggleClass("editableTextField");//.select();
        $(this).removeClass("editableTextField");
    }
    function OnKeyUpTextAreaAdjust(o, e) {
        o.css("height", "1px");
        var sh = o.prop("scrollHeight") + 20;
        o.css("height", sh + "px");
    }
    function CreateItem() {
        var item = $("<li>");
        var txt = $("<textarea name='mychklst_item' class='chklst_item' rows='1'></textarea>");
        txt.appendTo(item);
        return item;
    }
    function CreateSection() {
        var div = $("<div class='chklst_section'>");
        var name = $("<input name='mychklst_section_name' class='chklst_section_name' placeholder='type section name here'>").appendTo(div);
        var br = $("<br/>").appendTo(div);
        var desc = $("<input name='mychklst_section_desc' class='chklst_section_desc' placeholder='type section description here' rows='2'>").appendTo(div);
        var br2 = $("<br/>").appendTo(div);
        var ol = $("<ol class='chklst_items'>").appendTo(div);
        return div;
    }
    function ParseText(o, e) {
        var text = o.val();
        //Dose the text has any other character other than just blank spaces?
        if (text.trim().length > 0) {
            //split in lines
            var lines = text.split('\n');
            if (lines.length > 1) {
                //are last two lines are empty?
                if (lines[lines.length - 1].trim() === "" && lines[lines.length - 2].trim() === "") {
                    //for item textarea controls
                    if (o.attr("class").indexOf("chklst_item") >= 0) {
                        //trim current chklst_item text
                        o.val(text.trim());
                        //find next or create new
                        var actual_li = o.parent();
                        var ol = actual_li.parent();
                        var next_li = actual_li.next();
                        if (next_li.length > 0){
                            var next_item = next_li.children();
                            next_item.focus();
                        }
                        else {
                            //create and jump to a new item
                            var li = CreateItem();
                            ol.append(li);
                            var item = li.children();
                            item.focus();
                        }
                    }
                        //for chklst description textarea control
                    else if (o.attr("class").indexOf("chklst_desc") >= 0) {
                        //find first section otherwise create it
                        var divSec = $("#chklst_body").find("div:first");
                        if (divSec.length > 0) {
                            var input = divSec.find("input:first");
                            input.focus();
                        }
                        else {
                            var sec = CreateSection();
                            $("#chklst_body").append(sec);
                            var name = sec.find("input:first");
                            o.val(text.trim());
                            name.focus();
                        }
                    }

                    OnChanged();
                }
            }
        }
        else if (e.which == 8) {
            if (removeFlag) {
                removeFlag = false;
                if (o.attr("class").indexOf("item") >= 0) {
                    e.preventDefault();

                    //remove item
                    var parent = o.parent();
                    var prev = parent.prev();
                    if (prev.is("li")) {
                        var x = prev.children(".item");
                        if (x.length > 0) {
                            x.focus();
                        }
                    }
                    else {
                        var y = parent.parent().prev();
                        var z = y.prev();
                        if (z.is("input")) {
                            z.focus();
                        }
                    }
                    parent.remove();

                    OnChanged();
                }
            }
            else {
                removeFlag = true;
            }
        }
    }
    function ParseInput(o, e) {
        if (e.which == 13) {
            if (o.attr("class").indexOf("chklst_title") >= 0) {
                var a = $("br + .chklst_desc");
                if (a.length > 0) {
                    a.focus();
                }
            }
            else {
                var next = o.nextAll('input');
                //next input
                if (next.length > 0) {
                    next.focus();
                }
                else {
                    //next textarea (item)
                    next = o.nextAll(':has(.item):first').find('.item');
                    if (next.length > 0) {
                        next.focus();
                    }
                    else {
                        //create a new text area (item)
                        var li = CreateItem();
                        next = o.next().next();
                        if (next.length > 0) {
                            next.prepend(li);
                        }
                        var item = li.children();
                        item.focus();
                        o.val(o.val().trim());
                    }
                }
            }
        }
        else if (o.val().trim() === "" && e.which == 8) {
            if (removeFlag) {
                removeFlag = false;
                if (o.attr("class").indexOf("chklst_section_name") >= 0) {
                    var prev = o.parent().prev().find("textarea:last");
                    if (prev.length === 0) {
                        prev = o.parent().prev().find("input:last");
                        if (prev.length === 0) {
                            prev = $("#chklst_desc");
                        }
                    }
                    prev.focus();
                    o.parent().remove();
                }
                else {
                    var x = o.parent().find("input:first");
                    if (x.length === 0) {
                        x = o.parent().prev().find("input:last");
                    }
                    x.focus();
                }
            }
            else {
                removeFlag = true;
            }
        }
    }
    function OnKeyDownTextArea(o, e) {
        if (o.attr("class").indexOf("item") >= 0) {
            //Shift + tab
            if (e.which === 9 && e.shiftKey) {
                e.preventDefault();
                var txt = o.val().trim();
                var sec = CreateSection();
                //move to li > ol > div and insert new secction after current section
                o.parent().parent().parent().after(sec);
                var name = sec.find("input:first");
                name.val(txt);
                name.focus();
                e.stopPropagation();
                o.parent().remove();
            }
        }
    }
    function UpdateContent(id) {
        $("#chklst_id").val(id);
        var newToken = lastSentToken + 1;
        $("#chklst_token").val(newToken);
    }
    function UpdateChecklist(token, id, text) {
        if (token != lastSentToken)
        {
            var values = {
                'id': id,
                'content': text
            }
            $.post('MyChecklist/Update/', values, UpdateContent, 'json');
            lastSentToken = token;
        }
    }
    function OnChanged() {
        var content = $("#chklst_title").val().trim();
        content = content.concat("\n");
        content = content.concat($("#chklst_desc").val().trim());
        content = content.concat("\n");
        var chklst_body = $("#chklst_body");
        $("div.chklst_section").each(function () {
            var sec_name = $(this).find("input:first");
            content = content.concat(sec_name.val().trim());
            content = content.concat("\n");
            content = content.concat(sec_name.next().next().val().trim());
            content = content.concat("\n");
            var items = $(this).find("textarea");
            if (items.length > 0) {
                items.each(function () {
                    var text = $(this).val().trim();
                    var lines = text.split('\n');
                    if (lines.length > 1) {
                        for (i = 0; i < lines.length; i++) {
                            content = content.concat("\t").concat(lines[i]);
                        }
                    }
                    content = content.concat("\n");
                });
            }
        });

        var id = $("#chklst_id").val();
        var token = parseInt($("#chklst_token").val());

        UpdateChecklist(token, id, content);
    }

    $("body").delegate("textarea[name^=mychklst]", "focus", OnFocusStyle);
    $("body").delegate("textarea[name^=mychklst]", "focusout", OnFocusOutStyle);
    $("body").delegate("textarea[name=mychklst_item]", "change", function () {
        alert();
    });
    $("textarea[name=mychklst_item]").bind("input propertychange", function () {
        alert();
    });
    $("body").delegate("input[name^=mychklst]", "focus", OnFocusStyle);
    $("body").delegate("input[name^=mychklst]", "focusout", OnFocusOutStyle);
    $("body").delegate("input[name^=mychklst]", "keyup", function (e) {
        ParseInput($(this), e);
    });
    $("body").delegate("input[name^=mychklst]", "change", OnChanged);

    $("body").delegate("textarea[name^=mychklst]", "focus", OnFocusStyle);
    $("body").delegate("textarea[name^=mychklst]", "focusout", OnFocusOutStyle);
    $("body").delegate("textarea[name^=mychklst]", "keydown", function (e) {
        OnKeyDownTextArea($(this), e);
        ParseText($(this), e);
    });
    $("body").delegate("textarea[name^=mychklst]", "keyup", function (e) {
        ParseText($(this), e);
        OnKeyUpTextAreaAdjust($(this), e);
    });
});
