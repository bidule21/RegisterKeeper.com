function UpdatePositionLabels() {
	var registerCards = $("div.mix");
	//registerCards.sort(function (a, b) {
	//	//var aSortOrder = parseInt($(a).attr("data-sortorder"), 10);
	//	//var bSortOrder = parseInt($(b).attr("data-sortorder"), 10);
	//	//return bSortOrder - aSortOrder;

	//	a = $(a);
	//	b = $(b);
	//	var sortby = "data-sortorder";

	//	var sortAttrA = isNaN(a.attr(sortby) * 1) ? a.attr(sortby).toLowerCase() : a.attr(sortby) * 1,
	//			sortAttrB = isNaN(b.attr(sortby) * 1) ? b.attr(sortby).toLowerCase() : b.attr(sortby) * 1;
	//	if (sortAttrA < sortAttrB)
	//		return 1;
	//	if (sortAttrA > sortAttrB)
	//		return -1;
	//	return 0;
	//});

	var previousSortOrderValue = null;

	for (var i = 0; i < registerCards.length; i++) {
		var registerCard = $(registerCards[i]);

		var position = $(".position", registerCard);
		var thisSortOrderValue = parseInt(registerCard.attr("data-sortorder"), 10);
		if (thisSortOrderValue == 0) {
			position.text("");
		} else if (thisSortOrderValue == previousSortOrderValue) {
			position.text("=");
		} else {
			position.text(i + 1);
		}

		previousSortOrderValue = thisSortOrderValue;
	}
}

// Module augmentation - http://www.adequatelygood.com/JavaScript-Module-Pattern-In-Depth.html

var REGISTERKEEPERHUB;

$(function () {
	REGISTERKEEPERHUB = (function () {
		var hub = $.connection.registerKeeperHub;

		hub.client.ScoreUpdate = function (shotId, score) {
			var shotDisplay = $("#ShotId-" + shotId);
			shotDisplay.html(score);
			shotDisplay.stop(true, true).effect("highlight", null, 5000);

			// Check in case any scores were missed between the page rendering and the signalr connection 
			// being established
			// sighters are in SPANs (to allow strikethroughs), other shots are in TDs..
			(shotDisplay.is("span") ? shotDisplay.parent() : shotDisplay).prevAll().each(function () {
				var prevShotDisplay = $(this);
				var sighterSpanTest = $("span:first-child", prevShotDisplay)[0];
				if (sighterSpanTest) {
					prevShotDisplay = $(sighterSpanTest);
				}
				if (prevShotDisplay.text().trim() === "") {
					var prevShotId = parseInt(prevShotDisplay.attr('id').replace("ShotId-", ""), 10);
					hub.server.getScore(prevShotId).done(function (prevShotScore) {
						prevShotDisplay.html(prevShotScore);
					});
				}
			});

		};

		hub.client.ShootTotalScoreUpdate = function (shootId, score) {
			$("#ShootId-" + shootId + "-TotalScore").html(score);
		};

		hub.client.CompetitorTotalScoreUpdate = function (competitorId, score) {
			$("#CompetitorId-" + competitorId + "-TotalScore").html(score);
		};

		hub.client.TeamRegisterCardDistanceTotalScoreUpdate = function (teamRegisterCardId, distance, score) {
			$("#TeamRegisterCardId-" + teamRegisterCardId + "-" + distance + "-TotalScore").html(score);
		};

		hub.client.TeamRegisterCardTotalScoreUpdate = function (teamRegisterCardId, score) {
			$("#TeamRegisterCardId-" + teamRegisterCardId + "-TotalScore").html(score);
		};

		hub.client.RegisterCardSortOrderUpdate = function (registerCardId, sortorder) {
			$('#RegisterCardId-' + registerCardId).attr("data-sortorder", sortorder);
			$('#Grid').mixitup('sort', ['data-sortorder', 'asc']);
			//UpdatePositionLabels();
		};

		hub.client.TeamRegisterCardSortOrderUpdate = function (registerCardId, sortorder) {
			$('#TeamRegisterCardId-' + registerCardId).attr("data-sortorder", sortorder);
			$('#Grid').mixitup('sort', ['data-sortorder', 'asc']);
			//UpdatePositionLabels();
		};

		hub.client.SighterConversionUpdate = function (sighterId, converted) {
			if (converted) {
				$("#ShotId-" + sighterId).addClass("strikethrough");
			} else {
				$("#ShotId-" + sighterId).removeClass("strikethrough");
			}
		};

		$.connection.hub.logging = true;
		$.connection.hub.start();

		$('#Grid').mixitup({
			effects: ['fade'],
			onMixEnd: function () {
				UpdatePositionLabels();
			}
		});

		return hub;
	}());

});