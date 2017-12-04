// Write your JavaScript code.
$(document).ready(function () {
    
    $(".add").on("click", function () {        
        var line = $(this).closest('.tr_clone');        
        var clone = line.clone(true, true);
        clone.find(':text').val('');
        clone.find(':checkbox').prop('checked', false)
        clone.find(':hidden').val('');
        clone.removeClass("item-checked");
        line.after(clone);        
        clone.find(':text').focus();
    });

    $(".remove").on("click", function () {
        if ($(".tr_clone").length > 1) {
            var line = $(this).closest('.tr_clone');
            var ID = line.find(".ID");            

            if (ID.val() !== "") {
                $.ajax({
                    type: "DELETE",
                    url: "/api/ApiItems/" + ID.val(),
                    contentType: 'application/json',
                    success: function (resp) {
                        line.remove();
                        toastr.error("Item removido.")
                    },
                    error: function (err) {
                        toastr.error(err);
                    }
                });
            } else {
                line.remove();
            }
            
        }
    })

    $("input").on("change", function () {
        var line = $(this).closest('.tr_clone');
        var IDEl = line.find(".ID");
        var Nome = line.find(".input_item");
        var Checked = line.find(".input_item_check");
        var CheckedStatus = Checked.prop('checked');
        var ID = IDEl.val();
        var action = "";
        var message = "";

        var Item = {
            Nome: Nome.val(),
            Checked: CheckedStatus
        }
        
        if (ID === "") {
            action = "POST";
            message = "Item criado com sucesso.";
        } else {
            action = "PUT";
            Item.ID = ID;
            message = "Item atualizado com sucesso.";
        }
        
        $.ajax({
            type: action,
            url: "/api/ApiItems/" + ID,
            contentType: 'application/json',
            data: JSON.stringify(Item),
            success: function (resp) {
                if (CheckedStatus === true) {
                    line.addClass("item-checked");
                } else {
                    line.removeClass("item-checked");
                }

                toastr.success(message);
            },
            error: function (err) {
                if (err) {
                    console.log(err);
                }                
            }
        });
    })

})
