/*
Copyright (c) 2003-2012, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

var _FileBrowserLanguage = 'php';
var _QuickUploadLanguage = 'php';

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    config.language = 'zh-cn';
    config.skin = 'v2';
//    config.toolbar = 'editor1';
    config.toolbarCanCollapse = true;
    // config.uiColor = '#AADC6E';


//config.toolbar =
//   [
//      ['Source', '-', 'Preview', '-'],
//       ['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord'],
//       ['Undo', 'Redo', '-', 'Find', 'Replace', '-', 'SelectAll', 'RemoveFormat'],
//       '/',
//       ['Bold', 'Italic', 'Underline'],
//       ['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent'],
//       ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'],
//       ['Link', 'Unlink', 'Anchor'],
//       ['addpic', 'Flash', 'Table', 'HorizontalRule', 'Smiley', 'SpecialChar', 'PageBreak'], //此处的addpic为我们自定义的图标，非CKeditor提供。
//       '/',
//       ['Styles', 'Format', 'Font', 'FontSize'],
//       ['TextColor', 'BGColor'],

//   ];

//config.extraPlugins = 'addpic';
    config.filebrowserBrowseUrl = '../ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '../ckfinder/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = '../ckfinder/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '../ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '../ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    config.filebrowserFlashUploadUrl = '../ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';
};
