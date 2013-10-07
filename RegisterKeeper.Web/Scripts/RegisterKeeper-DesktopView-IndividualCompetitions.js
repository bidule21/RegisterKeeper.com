/// <reference path="RegisterKeeper-DesktopViewLiveScores.js" />
/// <reference path="jquery-1.9.1.intellisense.js" />

//var REGISTERKEEPERHUB;

$(function () {
	window.REGISTERKEEPERHUB = (function(hub) {
		hub.client.NewRegisterCard = function(registerCardId) {
			//$.ajax({
			//	type: "GET",
			//	url: "/Home/GetSomePartialView/",
			//	data: someArguments,
			//	success: function (viewHTML) {
			//		$("#someDiv").html(viewHTML);
			//	},
			//	error: function (errorData) { onError(errorData); }
			//});

			$.get(
				"/RegisterCards/Partial/" + registerCardId,
				function(registerCard) {
					$("#Grid").append($.parseHTML(registerCard));
					$('#Grid').mixitup('remix', 'all');
					$('#Grid').mixitup('sort', ['data-sortorder', 'asc']);
					//UpdatePositionLabels();
				}
			);
		};

		hub.client.DeletedRegisterCard = function(registerCardId) {
			$('#RegisterCardId-' + registerCardId).remove();
			$('#Grid').mixitup('remix', 'all');
			$('#Grid').mixitup('sort', ['data-sortorder', 'asc']);
			//UpdatePositionLabels();
		};

		return hub;
	}(window.REGISTERKEEPERHUB));
});