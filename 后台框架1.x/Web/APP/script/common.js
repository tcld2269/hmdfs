var serverurl = "http://www.ll191.com/AutoMallApp.asmx";
var machineurl = "http://www.ll191.com/";
var imgurl = "upload-file/images/Banner/";
var bannerurl = "upload-file/images/product/";
//var serverurl="http://xbyapp.korhst.ehtxidc.com/AutoMall.asmx";
//var machineurl="http://xbyshop.korhst.ehtxidc.com/";

var key = "ehtxapp";
window.onerror = function() {
	return true;
}

// 通用header的window
var openCommon = function(model,name, title, reserved, reserved1) {

	api.execScript({
		name : 'root',
		script : 'indexOpenCommon("' + model + '","' + name + '","' + title + '","' + reserved + '","' + reserved1 + '")'
	});
}
var openParentCommon = function(name, index) {
	api.execScript({
		name : 'root',
		script : 'indexOpenParentCommon("' + name + '",' + index + ')'
	});
}
//
// 打开分享浮动窗口
var openShareframe = function() {

	api.execScript({
		name : 'root',
		script : 'indexOpenShareframe()'
	});
}
//
// 请先登录提示
var showToast = function() {
	api.toast({
		msg : '请先登录',
		duration : 2000,
		location : 'middle'
	});
};

//
// // fun进入topic详细页
//     var funToTopic = function(){
//         // arguments
//         api.openFrame({
//             name: 'shareframe',
//             url: '../detailframes/shareframe.html',
//             bounces: false,
//             rect: {
//                 x: 0,
//                 y: 0,
//                 w: 'auto',
//                 h: 'auto'
//             }
//         });
//     };
// //

function updateCartCount() {
	var uid = $api.getStorage("uid");
	if (uid == null || uid == undefined) {
		//		api.toast({
		//			msg : '请先登录',
		//			duration : 1000,
		//			location : 'middle'
		//		});
		//		return;
	} else {
		var url = "/getCartCount?user_id=" + uid + "&key=" + key;
		ajaxRequest(url, "get", "", function(data) {
			//alert(data.result)
			if (data.result == "null" || data.result == "" || data.result == null || data.result == undefined) {
				$("#num_in_cart").html("0");
			} else {
				$("#num_in_cart").html(data.result);
			}
		});
	}

}

var add2cart = function(id, c, callBack) {
	//	if (api.winName != "root") {
	//		api.toast({
	//			msg : '添加成功',
	//			duration : 2000,
	//			location : 'middle'
	//		});
	//	}
	var count = 1;
	if (c != null) {
		count = c;
	}

	var uid = $api.getStorage("uid");
	if (uid == null || uid == undefined) {
		api.toast({
			msg : '请先登录',
			duration : 1000,
			location : 'middle'
		});
		return;
	}
	var url = "/addCart?user_id=" + uid + "&goods_id=" + id + "&goods_num=" + count + "&goods_mark=app&key=" + key;
	ajaxRequest(url, "get", "", function(data) {
		if (data.result == "true") {
			api.toast({
				msg : '添加成功',
				duration : 1000,
				location : 'middle'
			});

			api.sendEvent({
				name : 'cat_back',
				extra : {
					sav_param : '1'
				}
			});

			api.execScript({
				name : 'root',
				script : 'cart_plus("' + id + '",' + count + ')'
			});
			callBack(data);
		} else {
			alert(data.msg);
		}
	});
};
function ratio_img() {
	$(".ratio_img_0_8").each(function() {
		$(this).height($(this).width() * 0.8);
	});
	$(".ratio_img_1_0").each(function() {
		$(this).height($(this).width() * 1.0);
	});
}

function htmldecode(str) {
	str = str.replace(/&amp;/g, '&');
	//str = str.replace(/&nbsp;/g, ' ');
	str = str.replace(/&quot;/g, '"');
	str = str.replace(/&#39;/g, "'");
	str = str.replace(/&lt;/gi, '<');
	str = str.replace(/&gt;/gi, '>');
	//	str = str.replace(/<p>/g, '');
	//	str = str.replace(/<\/p>/g, '');
	//	str = str.replace(/<img/g, '<img style="width:100%;"');
	return str;
}

function ajaxRequest(url, method, datas, callBack) {
	var serverUrl = serverurl;
	var now = Date.now();
	api.ajax({
		url : serverUrl + url,
		method : method,
		cache : false,
		timeout : 30,
		dataType : 'json',
		data : {
			values : datas
		}
	}, function(ret, err) {
		if (ret) {
			callBack(ret, err);
		} else {
			//			api.alert({
			//				msg : ('错误码：' + err.code + '；错误信息：' + err.msg + '网络状态码：' + err.statusCode)
			//			});
		}
	});
}

//读文件
function readFile(path, callBack) {
	var cacheDir = api.cacheDir;
	api.readFile({
		path : cacheDir + path
	}, function(ret, err) {
		callBack(ret, err);
	});
}

//写文件
function writeFile(json, id, path) {
	//缓存目录
	var cacheDir = api.cacheDir;
	api.writeFile({
		//保存路径
		path : cacheDir + '/' + path + '/' + id + '.json',
		//保存数据，记得转换格式
		data : JSON.stringify(json)
	}, function(ret, err) {

	})
}

//缓存方法
function doCache(folder, id, url, callback) {
//	var systemType = api.systemType;
//	if(systemType=="ios")
//	{
//		//ios某些机型会闪退，测试一下
//		ajaxRequest(url, 'GET', '', function(ret, err) {
//				if (ret) {
//					callback(ret);
//				} else {
//					alert('数据获取失败！');
//				}
//			});
//		return;
//	}
	readFile('/' + folder + '/' + id + '.json', function(ret, err) {
		if (ret.status) {
			//如果成功，说明有本地存储，读取时转换下数据格式
			//拼装json代码
			//alert('取到缓存')
			var cacheData = ret.data;
			callback(JSON.parse(cacheData));
			iCache($('.cache'));
			//再远程取一下数据，防止有更新
			ajaxRequest(url, 'GET', '', function(ret, err) {
				if (ret) {
					if (cacheData != JSON.stringify(ret)) {
						//有更新处理返回数据
						//alert('更新缓存')
						callback(ret);
						//缓存数据
						writeFile(ret, id, folder);
						iCache($('.cache'));
					}
				} else {
					alert('数据获取失败！');
				}
			})
		} else {
			//如果失败则从服务器读取，利用上面的那个ajaxRequest方法从服务器GET数据
			ajaxRequest(url, 'GET', '', function(ret, err) {
				if (ret) {
					//处理返回数据
					//alert('没取到缓存')
					callback(ret);
					//缓存数据
					writeFile(ret, id, folder);
					iCache($('.cache'));
				} else {
					alert('数据获取失败！');
				}
			})
		}
	})
}

function requestAjax(url, folder, id, dealData) {
	ajaxRequest(url, 'GET', '', function(ret, err) {
		if (ret) {
			//处理返回数据
			dealData(ret);
			//缓存数据
			writeFile(ret, id, folder);
		} else {
			alert('数据获取失败！');
		}
	})
}

function updateAjax(url, folder, id) {
	ajaxRequest(url, 'GET', '', function(ret, err) {
		if (ret) {
			readFile('/' + folder + '/' + id + '.json', function(ret2, err) {
				if (ret2.status) {
					//如果成功，说明有本地存储，读取时转换下数据格式
					if (ret2.data != JSON.stringify(ret)) {
						//有更新
						//处理返回数据
						dealData(ret);
						//缓存数据
						writeFile(ret, id, folder);
					}
					iCache($('.cache'));
				}
			})
		} else {
			alert('数据获取失败！');
		}
	})
}

//缓存图片
function iCache(selector) {
	selector.each(function(data) {! function(data) {
			var url = selector.eq(data).attr("src");
			var img = this;
			var pos = url.lastIndexOf("/");
			var filename = url.substring(pos + 1);
			var path = api.cacheDir + "/pic/" + filename;
			var obj = api.require('fs');
			obj.exist({
				path : path
			}, function(ret, err) {
				//msg(ret);
				if (ret.exist) {
					if (ret.directory) {
						//api.alert({msg:'该路径指向一个文件夹'});
					} else {
						//api.alert({msg:'该路径指向一个文件'});
						//selector.eq(data).src=path;
						selector.eq(data).attr('src', null);
						path = api.cacheDir + "/pic/" + filename;
						selector.eq(data).attr('src', path);
						//console.log(selector.eq(data).attr("src"));
					}
				} else {
					api.download({
						url : url,
						savePath : path,
						report : false,
						cache : true,
						allowResume : true
					}, function(ret, err) {
						//msg(ret);
						if (ret) {
							var value = ('文件大小：' + ret.fileSize + '；下载进度：' + ret.percent + '；下载状态' + ret.state + '存储路径: ' + ret.savePath);
						} else {
							var value = err.msg;
						};
					});
				}
			});
		}(data);
	});
};

function downloadPic(url) {
	var pos = url.lastIndexOf("/");
	var filename = url.substring(pos + 1);
	var path = api.cacheDir + "/pic/" + filename;
	api.download({
		url : url,
		savePath : path,
		report : false,
		cache : false,
		allowResume : true
	}, function(ret, err) {
		//msg(ret);
		if (ret) {
			//var value = ('文件大小：' + ret.fileSize + '；下载进度：' + ret.percent + '；下载状态' + ret.state + '存储路径: ' + ret.savePath);
		} else {
			//var value = err.msg;
		};
	});
}
