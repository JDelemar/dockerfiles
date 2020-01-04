FROM php:7.4.1-apache-buster

ENV VERSION 2.1.50

#============================================
# elFinder
#============================================
RUN curl -L -O https://github.com/Studio-42/elFinder/archive/${VERSION}.zip \
    && apt-get update \
    && apt-get install -y \
        unzip \
    && unzip *.zip \
    && rm -f *.zip \
    && mv elFinder-* elFinder \
    && mv elFinder/php/connector.minimal.php-dist elFinder/php/connector.minimal.php \
    && chown -R www-data:www-data elFinder \
    && mv elFinder/* . \
    && mv elfinder.html index.html \
    # Clean up
    && apt-get autoremove -y \
    && apt-get clean -y \
    && rm -rf /var/lib/apt/lists/*
