function UpdatePositionLabels() {
	var registerCards = $("div.mix");
	registerCards.sort(function (a, b) {
		var aSortOrder = parseInt($(a).attr("data-sortorder"), 10);
		var bSortOrder = parseInt($(b).attr("data-sortorder"), 10);
		return bSortOrder - aSortOrder;
	});

	for (var i = 0; i < registerCards.length; i++) {
		var registerCard = registerCards[i];
		if (parseInt($(".position", registerCard).text().trim(), 10) !== i + 1) {
			$(".position", registerCard).text(i + 1);
		}
	}
}

$(function () {
	var hub = $.connection.registerKeeperHub;

	hub.client.ScoreUpdate = function (shotId, score) {
		$("#ShotId-" + shotId).html(score);
		$("#ShotId-" + shotId).stop(true, true).effect("highlight", null, 5000);
	};

	hub.client.ShootTotalScoreUpdate = function (shootId, score) {
		$("#ShootId-" + shootId + "-TotalScore").html(score);
	};

	hub.client.CompetitorTotalScoreUpdate = function (competitorId, score) {
		$("#CompetitorId-" + competitorId + "-TotalScore").html(score);
	};

	hub.client.TeamRegisterCardDistanceTotalScoreUpdate = function(teamRegisterCardId, distance, score) {
		$("#TeamRegisterCardId-" + teamRegisterCardId + "-" + distance + "-TotalScore").html(score);
	};

	hub.client.TeamRegisterCardTotalScoreUpdate = function (teamRegisterCardId, score) {
		$("#TeamRegisterCardId-" + teamRegisterCardId + "-TotalScore").html(score);
	};

	hub.client.RegisterCardSortOrderUpdate = function (registerCardId, sortorder) {
		$('#RegisterCardId-' + registerCardId).attr("data-sortorder", sortorder);
		UpdatePositionLabels();
		$('#Grid').mixitup('sort', ['data-sortorder', 'asc']);
	};
	
	hub.client.TeamRegisterCardSortOrderUpdate = function (registerCardId, sortorder) {
		$('#TeamRegisterCardId-' + registerCardId).attr("data-sortorder", sortorder);
		UpdatePositionLabels();
		$('#Grid').mixitup('sort', ['data-sortorder', 'asc']);
	};

	hub.client.SighterConversionUpdate = function(sighterId, converted) {
		if (converted) {
			$("#ShotId-" + sighterId).addClass("strikethrough");
		} else {
			$("#ShotId-" + sighterId).removeClass("strikethrough");
		}
	};

	$.connection.hub.start();

	$('#Grid').mixitup();

});