$(document).ready(function () {

    AplicarMascaras();

});


//-----------------------------------------------
// Eventos
//-----------------------------------------------

$(local.Id.BotaoMontarLanche).click(function () {
    
    $(local.Id.FormularioMontarLanchePersonalizado).submit();
});


//-----------------------------------------------
// Functions
//-----------------------------------------------

//Aplica máscara nos campos
function AplicarMascaras() {

    $(local.Id.CampoIngredienteAlface).mask('00');
    $(local.Id.CampoIngredienteBacon).mask('00');
    $(local.Id.CampoIngredienteHamburguerCarne).mask('00');
    $(local.Id.CampoIngredienteOvo).mask('00');
    $(local.Id.CampoIngredienteQueijo).mask('00');
}