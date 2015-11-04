$("form").submit( function () {
  var isChanged = false;  
    var form = document.forms[0];  
    for (var i = 0; i < form.elements.length; i++) {  
        var element = form.elements[i];  
        var type = element.type;  
        if (type == "text" || type == "hidden" || type == "textarea" || type == "button") {  
            if (element.value != element.defaultValue) {  
                isChanged = true;  
                break;  
            }  
        } else if (type == "radio" || type == "checkbox") {  
            if (element.checked != element.defaultChecked) {  
                isChanged = true;  
                break;  
            }  
        } else if (type == "select-one"|| type == "select-multiple") {  
            for (var j = 0; j < element.options.length; j++) {  
                if (element.options[j].selected != element.options[j].defaultSelected) {  
                    isChanged = true;  
                    break;  
                }  
            }  
        } else {   
          
        }       
    }      
    return isChanged;  
} );