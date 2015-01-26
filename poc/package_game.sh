rm -Rf /tmp/game_package
mkdir -p /tmp/game_package
cd /tmp/game_package
mkdir unity_game_development_files
cd unity_game_development_files
rsync -avz /Users/student/work/unity_from_gdoc/poc/test_create_p/* .
cd ..
mkdir unity_build_files
cd unity_build_files
cp /Users/student/work/unity_from_gdoc/poc/static/unity_builds/* .
cd /tmp
zip -r doc2gamefiles.zip game_package
cp doc2gamefiles.zip /Users/student/work/unity_from_gdoc/poc/static/unity_builds
