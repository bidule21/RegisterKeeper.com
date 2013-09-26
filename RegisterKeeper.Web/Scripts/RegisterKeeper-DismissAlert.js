
$('#DummyDatasetNotice').bind('closed', function () {
	$.cookie('DummyDatasetNoticeDismissed', 'true', { expires: 30, path: '/' });
})