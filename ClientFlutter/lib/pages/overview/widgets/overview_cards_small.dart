import 'package:flutter/material.dart';
import 'package:flutter_gen/gen_l10n/app_localizations.dart';
import 'package:linkso/pages/overview/widgets/info_card.dart';

class OverviewCardsSmall extends StatelessWidget {
  const OverviewCardsSmall({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final double _width = MediaQuery.of(context).size.width;
    return Column(
      children: [
        InfoCard(
          title: AppLocalizations.of(context)!.totalLinks,
          value: "7",
        ),
        SizedBox(height: _width / 64),
        InfoCard(
          title: AppLocalizations.of(context)!.totalClicks,
          value: "70",
        ),
        SizedBox(height: _width / 64),
        InfoCard(
          title: AppLocalizations.of(context)!.stat1,
          value: "1",
        ),
        SizedBox(height: _width / 64),
        InfoCard(
          title: AppLocalizations.of(context)!.stat1,
          value: "1",
        ),
      ],
    );
  }
}
